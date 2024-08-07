using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04
{
    internal class Program
    {
        // Використовуючи Visual Studio, створіть проект за шаблоном Console Application.
        // Потрібно: Створити клас Article, що містить наступні закриті поля:
        // • Назва товару;
        // • назва магазину, в якому продається товар;
        // • вартість товару в гривнях.
        // Створити клас Store, який містить закритий масив елементів типу Article.
        // Забезпечити такі можливості:
        // • висновок інформації про товар за номером за допомогою індексу;
        // • висновок на екран інформації про товар, назва якого введено з клавіатури, якщо таких товарів немає, видати відповідне повідомлення.
        // Написати програму, виведення на екран інформацію про товар.

        class Article
        {
            string name;
            string shop;
            double price;


            public string Name
            {
                get { return name; }
            }
            public string Shop
            {
                get { return shop; }
            }
            public double Price
            {
                get { return price; }
            }

            public Article(string name, string shop, double cost)
            {
                this.name = name;
                this.shop = shop;
                this.price = cost;
            }
            
        }

        class Store
        {

            Article[] articles;


            public Article this[int i]
            {
                get
                {
                    if (i < articles.Length)
                        return articles[i];
                    else
                        return null;
                }
            }


            public Article this[string s]
            {
                get
                {
                    for (int i = 0; i < articles.Length; i++)
                    {
                        if (articles[i].Name == s)
                            return articles[i];
                    }

                    return null;
                }
            }

            public int Lenght
            {
                get
                {
                    return articles.Length;
                }
            }

            public Store()
            {
                articles = new Article[0];
            }





            public void Add(string name, string shop, double cost)
            {
                Article article = new Article(name, shop, cost);

                Array.Resize(ref  articles, articles.Length + 1);
                articles[articles.Length - 1] = article;

            }



        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;

            Store store = new Store();
            store.Add("карандаш", "Сільпо", 12.5);
            store.Add("ручка", "Сільпо", 22.5);
            store.Add("зошит", "Сільпо", 60);
            store.Add("щоденник", "Сільпо", 90);
            store.Add("коректор", "АТБ", 125);


            while (true)
            {
                Console.Write("Введіть назву або індекс товару: ");
                string s;
                s = Console.ReadLine();

                Article article;

                if (int.TryParse(s, out int i) && (article = store[i]) != null)
                    ;
                else if ((article = store[s]) != null)
                    ;
                else
                {
                    Console.WriteLine("такого товару немає");
                    continue;
                }

                Console.WriteLine("ім'я: {0}, магазин: {1}, вартість: {2}", article.Name, article.Shop, article.Price);

                Console.WriteLine(new string('-',30));
            }

            Console.ReadKey();
        }
    }
}
