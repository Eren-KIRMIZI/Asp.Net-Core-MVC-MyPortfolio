# MyPortfolio — ASP.NET Core MVC Portfolio Website

## Proje Hakkında

Bu proje, ASP.NET Core MVC teknolojisi kullanılarak geliştirilmiş kişisel bir portfolyo web sitesidir.  
Proje, Code First yaklaşımı ile MSSQL veritabanı üzerinde çalışmaktadır.

## Özellikler

### Admin Paneli (CRUD işlemleri)

* Deneyim (Experience) yönetimi  
* Hakkımda (About) düzenleme  
* Mesaj (Contact) görüntüleme  
* ToDo List yönetimi  

### Kullanıcı Arayüzü

* Dinamik bileşenler (_NavbarComponentPartial, _AboutComponentPartial, _FeatureComponentPartial vb.)  
* Bootstrap tabanlı modern tasarım  

## Teknolojiler ve Yapı

* MSSQL Code First veri tabanı  
* Entity Framework Core ORM  
* Katmanlı mimari yapı (DAL, Entity, Controller, View)  

## Kurulum

* Projeyi klonla  
  ```
  git clone https://github.com/Eren-KIRMIZI/Asp.Net-Core-MVC-MyPortfolio.git
  ```

* Visual Studio ile projeyi aç  

* `appsettings.json` dosyasında veritabanı bağlantı ayarlarını yapılandır  
  ```
  "ConnectionStrings": {
      "DefaultConnection": "Server=.;Database=MyPortfolioDb;Trusted_Connection=True;"
  }
  ```

* Veritabanını oluştur  
  ```
  dotnet ef database update
  ```

* Uygulamayı çalıştır  
  ```
  dotnet run
  ```
