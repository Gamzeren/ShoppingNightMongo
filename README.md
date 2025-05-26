# 🛍️ MongoDB ile E-Ticaret Sitesi
Bu repository, M&Y Yazılım Akademi'de gerçekleştirdiğim üçüncü proje olan Coza Store - MongoDB ile geliştirilmiş bir E-Ticaret Uygulamasını içermektedir.
## 🛒 Proje Hakkında
Coza Store, ASP.NET Core 8.0 ve MongoDB kullanılarak geliştirilen, kullanıcı tabanlı ve tamamen işlevsel bir e-ticaret platformudur. Modern alışveriş alışkanlıklarını ve kullanıcı beklentilerini göz önünde bulundurarak tasarladığım bu proje, hem teknik mimarisi hem de kullanıcı deneyimi ile öne çıkıyor.
MongoDB’nin NoSQL yapısından faydalanarak ürün, kategori, kullanıcı gibi temel veri yapıları esnek ve performanslı şekilde yönetildi. Ayrıca, MongoDB.Driver ve MongoDB.Bson kütüphaneleri sayesinde veri işlemlerini rahatlıkla gerçekleştirebildim.
## 🧩 Uygulama Yapısı
Sistem iki ana bölümden oluşuyor:</br>
**👤Admin Paneli:** Ürün yönetimi, kategori düzenleme, stok kontrolü ve sipariş takibi gibi temel işlemlerin yapılabildiği yönetim paneli.</br>
**📱Vitrin Paneli:** Kullanıcıların ürünleri kategorilere göre filtreleyip alışveriş yapabildikleri, responsive ve kullanıcı dostu bir arayüz.</br>
Projede; ürünlere çoklu görsel ekleme, kategori bazlı filtreleme, kullanıcı yorumları, dinamik içerik yönetimi gibi birçok gelişmiş özellik yer almakta.
## 🗄️ MongoDB ve Veri İşlemleri
Projede ilişkisel veritabanı yerine MongoDB kullandım. JSON benzeri BSON formatı sayesinde ürün, kategori ve kullanıcı gibi veriler oldukça esnek şekilde modellendi.
#### Kullanılan bazı MongoDB metotları:
💎Create: InsertOneAsync()</br>
💎Read: Find(), FindAsync()</br>
💎Update: UpdateOneAsync(), ReplaceOneAsync()</br>
💎Delete: DeleteOneAsync()</br>
Veri modelleri, C# sınıfları (Entities) olarak tanımlandı ve dışa veri aktarımı için DTO’lar kullanıldı. Böylece hem veri güvenliği hem de performans açısından daha verimli bir yapı elde edildi.
## 🔧 Teknik Yapı ve Mimarisi
Projeyi her ne kadar tek katmanlı olarak geliştirsem de, iç mimaride katmanlı mimari prensiplerine sadık kaldım. Yapı şu şekilde organize edildi:</br>
💎Entities (Veri modelleri)</br>
💎DTOs (Veri transfer nesneleri)</br>
💎Services (İş mantığı)</br>
💎Controllers & Views (MVC Yapısı)</br>
💎ViewComponents (Parçalı yapı yönetimi)</br>
Ayrıca projede AutoMapper kullanarak modeller arası dönüşümleri kolaylaştırdım. Arayüz tarafında ise Bootstrap 5 ile modern ve mobil uyumlu bir tasarım hedefledim.
## 📬 Ekstra Özellikler
💎SMTP ile e-posta bildirim sistemi</br>
💎Gelişmiş filtreleme ve arama altyapısı</br>
💎Responsive tasarım</br>
💎Kategori bazlı ürün filtreleme</br>
💎Çoklu ürün görseli yönetimi</br>
## 🛠️ Kullanılan Teknolojiler
💎ASP.NET Core 6.0 — Modern web uygulamaları için güçlü bir framework</br>
💎MongoDB — Esnek, doküman tabanlı NoSQL veritabanı</br>
💎MongoDB.Driver & MongoDB.Bson — .NET ile MongoDB arasında veri iletişimi</br>
💎AutoMapper — Nesneler arası dönüşüm kolaylığı</br>
💎Razor Pages / MVC — Dinamik ve modüler sayfa yönetimi</br>
💎HTML5, CSS3, JavaScript — Ön yüz tasarımı</br>
💎ViewComponent — Arayüzde parçalı yapı desteği</br>
💎Katmanlı Yapı — SOLID prensiplerine uygun dosya mimarisi</br>
Bu proje sayesinde .NET Core dünyasında MongoDB ile çalışmayı deneyimledim, katmanlı mimariyi uygulamalı olarak öğrenme fırsatı buldum ve gerçek bir e-ticaret projesini baştan sona kurgulama deneyimi edindim. Geliştirmeye ve üzerine yeni modüller eklemeye açık olan bu yapı, hem öğrenmek isteyen geliştiriciler hem de gerçek dünya uygulamalarını keşfetmek isteyenler için güzel bir başlangıç noktası olabilir.
## 🌸 Projeden Ekran Görüntüleri
### 🎀 Vitrin Paneli

![Image](https://github.com/user-attachments/assets/9a92d4d6-7258-4443-9a44-d60fc0701b6d)

![Image](https://github.com/user-attachments/assets/005dce11-08f1-4e1e-bee4-b7c44b646566)

![Image](https://github.com/user-attachments/assets/d936ed8d-0476-4ebb-a6e5-dbc34176db9c)

![Image](https://github.com/user-attachments/assets/ddf2a532-dd60-4f99-8314-03d5180ab784)

![Image](https://github.com/user-attachments/assets/3e7c9ecc-ee35-42f7-a58c-4f90cb48f6b9)

![Image](https://github.com/user-attachments/assets/5443daf4-6dd0-4585-94a2-9a3e021147af)

##### 📑 Product Detail 
![Image](https://github.com/user-attachments/assets/26d8fe29-fdfd-44fd-9fb6-b3b6a36c15b7)

![Image](https://github.com/user-attachments/assets/977c8910-df10-41d4-b5f0-38b260d24552)

![Image](https://github.com/user-attachments/assets/087ac200-7151-4296-bed2-2816ebd18302)

### 💌 Gerçek Zamanlı İndirim Kuponu Gönderilen Mail

![Image](https://github.com/user-attachments/assets/db988219-5997-4738-b78b-f46a69dab907)

### 💻 Admin Paneli

![Image](https://github.com/user-attachments/assets/e3c5ae0b-04da-43fc-8998-bdac28c76595)

![Image](https://github.com/user-attachments/assets/503c27b0-4bdc-4fad-a668-4333787e9104)

![Image](https://github.com/user-attachments/assets/e2034360-31e5-4973-bcc0-f906cb01907c)

![Image](https://github.com/user-attachments/assets/81cd0daf-dd07-4cb2-853e-085b47446e39)

![Image](https://github.com/user-attachments/assets/d50e9b46-e19c-4d8f-9841-0dafe31c24f2)
