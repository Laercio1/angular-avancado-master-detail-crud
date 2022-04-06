import { InMemoryDbService } from "angular-in-memory-web-api";
import { Purchase } from "./pages/purchase/shared/purchase.model";
import { Category } from "./pages/categories/shared/category.model";
import { Sale } from "./pages/sales/shared/sale.model";
import { Product } from './pages/products/shared/product.model';
import { Customer } from "./pages/customers/shared/customer.model";
export class InMemoryDatabase implements InMemoryDbService {
  createDb() {
    const customers: Customer[] = [
     { id: 1, name: 'Lucas Oliveira da Silva', CNPJ_CPF: '068.958.458-51', birth_date: '15/05/1999', address: 'Rua Castelo Branco', district: 'Centro', city: 'Araguaína', state: 'Tocantins', country: 'Brasil', telephone: '063 992214373', email: 'lucasSilva@gmail.com', description: 'Trabalha atualmente como administrador de um loja de produtos químicos.' },
     { id: 2, name: 'Samuel Costa Castro', CNPJ_CPF: '045.745.458-78', birth_date: '18/01/1991', address: 'Rua Almeida', district: 'Senador', city: 'Araguaína', state: 'Tocantins', country: 'Brasil', telephone: '063 992453698', email: 'samuelcastro@gmail.com', description: 'Trabalha atualmente como auxiliar de serviços gerais.' },
     { id: 3, name: 'Patricia Gomes Ferreira', CNPJ_CPF: '025.698.478-28', birth_date: '05/10/2000', address: 'Rua Limeira', district: 'Bueno', city: 'Colinas', state: 'Tocantins', country: 'Brasil', telephone: '063 991256489', email: 'patriciagomes@gmail.com', description: 'Trabalha atualmente como secretátia de advogado.' },
     { id: 4, name: 'João Vicente Nunes Ferraz', CNPJ_CPF: '098.158.278-36', birth_date: '02/12/1978', address: 'Rua Paulista', district: 'Girassol', city: 'Araguatins', state: 'Tocantins', country: 'Brasil', telephone: '063 992658749', email: 'joãovicente@gmail.com', description: 'Trabalha atualmente como gerente de empresa.' },
     { id: 5, name: 'Felipe Fernandes Almeida', CNPJ_CPF: '025.458.859-47', birth_date: '25/08/1997', address: 'Rua Costa', district: 'Centro', city: 'Araguaína', state: 'Tocantins', country: 'Brasil', telephone: '063 99226598', email: 'felipe@gmail.com', description: 'Trabalha atualmente como atendente de caixa.' },
     { id: 6, name: 'Emanuel Andrade Soares', CNPJ_CPF: '011.489.756-07', birth_date: '14/06/2001', address: 'Rua Adventista', district: 'Sul', city: 'Aragominas', state: 'Tocantins', country: 'Brasil', telephone: '063 992001547', email: 'emanuel@gmail.com', description: 'Trabalha atualmente como técnico de enfermagem.' },
     { id: 7, name: 'Vanessa Costa de Sousa', CNPJ_CPF: '088.698.978-09', birth_date: '19/07/1992', address: 'Rua Tocantins', district: 'Norte', city: 'Araguaína', state: 'Tocantins', country: 'Brasil', telephone: '063 992031498', email: 'vanessa@gmail.com', description: 'Trabalha atualmente como agropecuária.' },
     { id: 8, name: 'João Nascimento de Sousa', CNPJ_CPF: '088.698.978-09', birth_date: '19/07/1992', address: 'Rua Tocantins', district: 'Norte', city: 'Araguaína', state: 'Tocantins', country: 'Brasil', telephone: '063 992031498', email: 'vanessa@gmail.com', description: 'Trabalha atualmente como agropecuária.' }
    ];

    const categories: Category[] = [
      { id: 1, namefancy: "Distribuidora LTS", CNPJ: '05.311.244/0001-09', telephone: '062 99265-9865', email: 'distribuidoraLTS@gmail.com.br', city: 'Araguaína', state: 'Tocantins', country: 'Brasil'  } as Category,
      { id: 2, namefancy: "Distribuidora Eletrico", CNPJ: '09.698.659/0048-02', telephone: '045 99965-8545', email: 'distribuidoraeletrico@gmail.com.br', city: 'Salvador', state: 'Bahia', country: 'Brasil'  } as Category,
      { id: 3, namefancy: "Distribuidora Lima", CNPJ: '07.258.754/0045-01', telephone: '084 84665-6597', email: 'distribuidoralima@gmail.com.br', city: 'Paraupebas', state: 'Pará', country: 'Brasil'  } as Category,
      { id: 4, namefancy: "Distribuidora Sulista", CNPJ: '03.377.632/0049-05', telephone: '074 99596-4536', email: 'distribuidorasulista@gmail.com.br', city: 'Curitiba', state: 'Paraná', country: 'Brasil'  } as Category,
      { id: 5, namefancy: "Distribuidora Centro Norte", CNPJ: '01.288.312/0329-12', telephone: '063 99265-9865', email: 'distribuidoracentronorte@gmail.com.br', city: 'Palmas', state: 'Tocantins', country: 'Brasil'  } as Category,
      { id: 6, namefancy: "Distribuidora WSL", CNPJ: '11.032.336/0023-18', telephone: '021 11235-1559', email: 'distribuidorawls@gmail.com.br', city: 'Campinas', state: 'São Paulo', country: 'Brasil'  } as Category,
      { id: 7, namefancy: "Distribuidora Norte", CNPJ: '02.398.487/8590-14', telephone: '062 99165-9978', email: 'distribuidoranorte@gmail.com.br', city: 'Goiânia', state: 'Goiás', country: 'Brasil'  } as Category,
      { id: 8, namefancy: "Distribuidora Eletrosul", CNPJ: '02.398.487/8590-14', telephone: '062 99165-9978', email: 'distribuidoraeletrosul@gmail.com.br', city: 'Goiânia', state: 'Goiás', country: 'Brasil'  } as Category
    ];

    const products: Product[] = [
      { id: 6, name: 'Computador', stock: 10, marca: 'LG', category: 'Computador', description: 'Computador de última geração.', amount: '3850,00' } as Product,
      { id: 5, name: 'Video Game', stock: 13, marca: 'Sansung', category: 'Game', description: 'Video game nível 5.', amount: '1980,00' } as Product,
      { id: 15, name: 'Smart TV', stock: 9, marca: 'Sony', category: 'Televisão', description: 'Smart TV 50 polegadas', amount: '2500,00' } as Product,
      { id: 11, name: 'Smartphone', stock: 16, marca: 'Philco',  category: 'Celular', description: 'Smartphone sansung S10.', amount: '1750,00' } as Product,
      { id: 4, name: 'Tablet', stock: 21, marca: 'Asus',  category: 'Computador', description: 'Tablet de última geração.', amount: '935,00' },
      { id: 18, name: 'Fone de ouvido', stock: 8, marca: 'Microsoft',  category: 'Acessório', description: 'Fone de ouvido de última geração.', amount: '158,00'} as Product,
      { id: 21, name: 'Mouse', stock: 11, marca: 'Dell',  category: 'Computador', description: 'Mouse inovados para computadores e notebook.', amount: '68,00'} as Product,
      { id: 27, name: 'Celular', stock: 11, marca: 'Sansung',  category: 'Celular', description: 'Smartphone com estilos mordenos.', amount: '1568,00'} as Product
    ];

    const sales: Sale[] = [
      { id: 55, vendor: 'Luciano Tavares', quatity: 3, productId: products[0].id, product: products[0], paid: true, date: "14/10/2018", amount: "3390,80", customerId: customers[1].id, customer: customers[1], type: "revenue", description: "Qualquer descrição para essa despesa" } as Sale,
      { id: 44, vendor: 'Marcelo Melo', quatity: 2, productId: products[1].id, product: products[1], paid: false, date: "14/10/2018", amount: "5500,00", customerId: customers[2].id, customer: customers[2], type: "revenue" } as Sale,
      { id: 23, vendor: 'Patricia Moura', quatity: 15, productId: products[3].id, product: products[3], paid: true, date: "15/11/2018", amount: "15405,49", customerId: customers[3].id, customer: customers[3], type: "revenue" } as Sale,
      { id: 22, vendor: 'Luciano Tavares', quatity: 5, productId: products[2].id, product: products[2], paid: true, date: "16/10/2018", amount: "5590,00", customerId: customers[1].id, customer: customers[1], type: "revenue" } as Sale,
      { id: 21, vendor: 'Marcelo Melo', quatity: 5, productId: products[1].id, product: products[1], paid: true, date: "17/10/2018", amount: "6008,00", customerId: customers[1].id, customer: customers[1], type: "revenue" } as Sale,
      { id: 19, vendor: 'Henrique Gomes', quatity: 4, productId: products[2].id, product: products[2], paid: false, date: "17/11/2018", amount: "6569,00", customerId: customers[2].id, customer: customers[2], type: "revenue" } as Sale,
      { id: 14, vendor: 'Patricia Moura', quatity: 15, productId: products[1].id, product: products[1], paid: true, date: "17/11/2018", amount: "15980,00", customerId: customers[3].id, customer: customers[3], type: "revenue" } as Sale,
      { id: 13, vendor: 'Paulo Almotino', quatity: 6, productId: products[2].id, product: products[2], paid: false, date: "23/10/2018", amount: "4897,00", customerId: customers[1].id, customer: customers[1], type: "revenue" } as Sale,
      { id: 8, vendor: 'Pedro Sampaio', quatity: 5, productId: products[1].id, product: products[1], paid: false, date: "25/10/2018", amount: "7579,00", customerId: customers[1].id, customer: customers[1], type: "revenue" } as Sale,
      { id: 10, vendor: 'Marcelo Melo', quatity: 5, productId: products[4].id, product: products[4], paid: true, date: "25/10/2018", amount: "4980,00", customerId: customers[2].id, customer: customers[2], type: "revenue" } as Sale,
      { id: 9, vendor: 'Luciano Tavares', quatity: 15, productId: products[2].id, product: products[2], paid: false, date: "07/11/2018", amount: "12018,00", customerId: customers[3].id, customer: customers[3], type: "revenue" } as Sale
    ];

    const purchase: Purchase[] = [
      { id: 1, buyer: 'João Miguel', quatity: 10, productId: products[1].id, product: products[1], paid: true, date: "15/11/2018", amount: "3000,50", type: "expense", description: "Qualquer descrição para essa compra.", categoryId: categories[1].id, category: categories[1] } as Purchase,
      { id: 24, buyer: 'Bruno Silva', quatity: 15, productId: products[2].id, product: products[2], paid: false, date: "15/10/2018", amount: "2584,50", type: "expense", description: "Qualquer descrição para essa compra.", categoryId: categories[2].id, category: categories[2] } as Purchase,
      { id: 35, buyer: 'João Miguel', quatity: 8, productId: products[3].id, product: products[3], paid: true, date: "15/10/2018", amount: "1985,50", type: "expense", description: "Qualquer descrição para essa compra.", categoryId: categories[3].id, category: categories[3] } as Purchase,
      { id: 42, buyer: 'Rodrigo Nogueira', quatity: 7, productId: products[4].id, product: products[4], paid: true, date: "15/11/2018", amount: "4985,50", type: "expense", description: "Qualquer descrição para essa compra.", categoryId: categories[4].id, category: categories[4] } as Purchase,
      { id: 54, buyer: 'Bruno Sampaio', quatity: 15, productId: products[5].id, product: products[5], paid: false, date: "16/11/2018", amount: "4984,50", type: "expense", description: "Qualquer descrição para essa compra.", categoryId: categories[5].id, category: categories[5] } as Purchase,
      { id: 68, buyer: 'Felipe Santos', quatity: 11, productId: products[6].id, product: products[6], paid: false, date: "16/11/2018", amount: "5698,50", type: "expense", description: "Qualquer descrição para essa compra.", categoryId: categories[3].id, category: categories[3] } as Purchase,
      { id: 77, buyer: 'João Miguel', quatity: 9, productId: products[1].id, product: products[1], paid: false, date: "18/10/2018", amount: "7598,50", type: "expense", description: "Qualquer descrição para essa compra.", categoryId: categories[2].id, category: categories[2] } as Purchase,
      { id: 86, buyer: 'Bruno Silva', quatity: 18, productId: products[6].id, product: products[6], paid: false, date: "18/10/2018", amount: "4568,50", type: "expense", description: "Qualquer descrição para essa compra.", categoryId: categories[4].id, category: categories[4] } as Purchase,
      { id: 94, buyer: 'Felipe Santos', quatity: 6, productId: products[2].id, product: products[2], paid: true, date: "20/11/2018", amount: "4758,50", type: "expense", description: "Qualquer descrição para essa compra.", categoryId: categories[4].id, category: categories[4] } as Purchase,
      { id: 18, buyer: 'Rodrigo Nogueira', quatity: 9, productId: products[5].id, product: products[5], paid: false, date: "20/10/2018", amount: "4695,50", type: "expense", description: "Qualquer descrição para essa compra.", categoryId: categories[3].id, category: categories[3] } as Purchase,
      { id: 17, buyer: 'João Miguel', quatity: 17, productId: products[4].id, product: products[4], paid: false, date: "20/11/2018", amount: "4586,50", type: "expense", description: "Qualquer descrição para essa compra.", categoryId: categories[5].id, category: categories[5] } as Purchase,

    ];


    return { categories, sales, purchase, products, customers }
  }
}
