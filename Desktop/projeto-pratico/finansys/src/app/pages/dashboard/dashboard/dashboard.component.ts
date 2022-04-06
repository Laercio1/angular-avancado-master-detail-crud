import { Component, OnInit, ViewChild, ElementRef } from '@angular/core';

import { Sale } from '../../sales/shared/sale.model';
import { SaleService } from '../../sales/shared/sale.service';

import currencyFormatter from 'currency-formatter'
import { Product } from '../../products/shared/product.model';
import { ProductService } from '../../products/shared/product.service';
import { Purchase } from '../../purchase/shared/purchase.model';
import { PurchaseService } from '../../purchase/shared/purchase.service';
@Component({
  selector: 'app-dashboard',
  templateUrl: './dashboard.component.html',
  styleUrls: ['./dashboard.component.css']
})
export class DashboardComponent implements OnInit {

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
  sales: Sale[] = [];
  purchase: Purchase[] = [];

  @ViewChild('month') month: ElementRef = null;
  @ViewChild('year') year: ElementRef = null;

  constructor(private saleService: SaleService, private productService: ProductService, private purchaseService: PurchaseService) { }

  ngOnInit() {
    this.productService.getAll()
    .subscribe(products => this.products = products);
  }

  generateReports() {
    const month = this.month.nativeElement.value;
    const year = this.year.nativeElement.value;

    if (!month || !year)
        alert('Você precisa selecionar o Mês e o Ano para gerar os relatórios')

        this.saleService.getByMonthAndYear(month, year).subscribe(this.setValues.bind(this))
  }

  private setValues(sales: Sale[]){
    this.sales = sales;
    this.calculateBalance();
    this.setChartData();
    this.setChartDataProducts();
  }

  private calculateBalance(){
    let revenueTotal = 0;
    let productTotal = 0;

    this.sales.forEach(sale => {
      if (sale.type == 'revenue')
      revenueTotal += currencyFormatter.unformat(sale.amount, { code: 'BRL' })
      productTotal += currencyFormatter.unformat(sale.quatity, { code: 'BRL' })

    });
    this.revenueTotal = currencyFormatter.format(revenueTotal, { code: 'BRL' });
    this.productsTotal = productTotal;
  }

  setChartData(){
    this.revenueChartData = this.getChartData('revenue', 'Gráfico de Vendas', '#9CCC65');

  }


  setChartDataProducts(){
    this.expenseChartData = this.getChartDataProducts('revenue', 'Gráfico de Produtos', '#0d8edb')

  }

  private getChartData(saleType: string, title: string, color: string){

    const chartData = [];

    this.products.forEach(product => {
      // filtrando lançamentos por categoria e tipo
      const filteredSales = this.sales.filter(
        sale => (sale.productId == product.id) && (sale.type == saleType)
      );

      if (filteredSales.length > 0){
        const totalAmount = filteredSales.reduce(
          (total, sale) => total + currencyFormatter.unformat(sale.amount, { code: 'BRL' }), 0
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

  private getChartDataProducts(saleType: string, title: string, color: string){

    const chartData = [];

    this.products.forEach(product => {
      // filtrando lançamentos por categoria e tipo
      const filteredSales = this.sales.filter(
        sale => (sale.productId == product.id) && (sale.type == saleType)
      );

      if (filteredSales.length > 0){
        const totalAmount = filteredSales.reduce(
          (total, sale) => total + currencyFormatter.unformat(sale.quatity, { code: 'BRL' }), 0
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

