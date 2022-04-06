import { Component, ElementRef, OnInit, ViewChild } from '@angular/core';
import { Purchase } from '../../purchase/shared/purchase.model';
import { PurchaseService } from '../../purchase/shared/purchase.service';
import { Product } from '../../products/shared/product.model';
import { ProductService } from '../../products/shared/product.service';

import currencyFormatter from 'currency-formatter'

@Component({
  selector: 'app-report',
  templateUrl: './report.component.html',
  styleUrls: ['./report.component.css']
})
export class ReportComponent implements OnInit {

  revenueTotal: any = 0;

  productsTotal: any = 0;

  expenseChartData: any;
  revenueChartData: any;

  chartOptions = {
    scales: {
      yAxes: [{
        ticks: {
          beginAtZero: true
        }
      }]
    }
  };

  products: Product[] = [];
  brands: Purchase[] = [];

  @ViewChild('month') month: ElementRef = null;
  @ViewChild('year') year: ElementRef = null;

  constructor( private productService: ProductService, private brandService: PurchaseService) { }

  ngOnInit() {
    this.productService.getAll()
    .subscribe(products => this.products = products);
  }

  generateReports() {
    const month = this.month.nativeElement.value;
    const year = this.year.nativeElement.value;

    if (!month || !year)
        alert('Você precisa selecionar o Mês e o Ano para gerar os relatórios')

        this.brandService.getByMonthAndYear(month, year).subscribe(this.setValues.bind(this))
  }

  private setValues(brands: Purchase[]){
    this.brands = brands;
    this.calculateBalance();
    this.setChartData();
    this.setChartDataProducts();
  }

  private calculateBalance(){
    let revenueTotal = 0;
    let productTotal = 0;

    this.brands.forEach(brand => {
      if (brand.type == 'expense')
      revenueTotal += currencyFormatter.unformat(brand.amount, { code: 'BRL' })
      productTotal += currencyFormatter.unformat(brand.quatity, { code: 'BRL' })

    });
    this.revenueTotal = currencyFormatter.format(revenueTotal, { code: 'BRL' });
    this.productsTotal = productTotal;
  }

  setChartData(){
    this.revenueChartData = this.getChartData('expense', 'Gráfico de Compras', '#e03131');

  }


  setChartDataProducts(){
    this.expenseChartData = this.getChartDataProducts('expense', 'Gráfico de Produtos', '#b5b808')

  }

  private getChartData(brandType: string, title: string, color: string){

    const chartData = [];

    this.products.forEach(product => {
      // filtrando lançamentos por categoria e tipo
      const filteredBrands = this.brands.filter(
        brand => (brand.productId == product.id) && (brand.type == brandType)
      );

      if (filteredBrands.length > 0){
        const totalAmount = filteredBrands.reduce(
          (total, brand) => total + currencyFormatter.unformat(brand.amount, { code: 'BRL' }), 0
        )

        chartData.push({
          productName: product.name,
          totalAmount: totalAmount
        })
      }
    });

    return {
      labels: chartData.map(item => item.productName),
      datasets: [{
        label: title,
        backgroundColor: color,
        data: chartData.map(item => item.totalAmount)
      }]
    }
  }

  private getChartDataProducts(brandType: string, title: string, color: string){

    const chartData = [];

    this.products.forEach(product => {
      // filtrando lançamentos por categoria e tipo
      const filteredBrands = this.brands.filter(
        brand => (brand.productId == product.id) && (brand.type == brandType)
      );

      if (filteredBrands.length > 0){
        const totalAmount = filteredBrands.reduce(
          (total, brand) => total + currencyFormatter.unformat(brand.quatity, { code: 'BRL' }), 0
        )

        chartData.push({
          productName: product.name,
          totalAmount: totalAmount
        })
      }
    });

    return {
      labels: chartData.map(item => item.productName),
      datasets: [{
        label: title,
        backgroundColor: color,
        data: chartData.map(item => item.totalAmount)
      }]
    }
  }

}
