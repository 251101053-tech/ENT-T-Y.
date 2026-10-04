# C# Windows Forms & Entity Framework CRUD Otomasyonu

Bu proje, C# Windows Forms arayüzü ve Entity Framework ORM mimarisi kullanılarak geliştirilmiş, yerel Microsoft SQL Server veritabanı ile tam entegre çalışan bir masaüstü veri yönetim uygulamasıdır.

## 📌 Proje Özellikleri ve Yetenekleri
- **Listeleme (Read):** SQL Server üzerindeki `dbo.RAYS` tablosunda bulunan tüm kayıtlar, uygulama açılışında DataGridView bileşenine dinamik olarak listelenir.
- **Ekleme (Create):** Arayüzdeki metin kutuları (`txtMail`, `txtAd`, `txtSoyad`) üzerinden girilen numara, ad ve soyad bilgileri yeni bir nesne olarak veritabanına kaydedilir.
- **Güncelleme (Update):** Tablodan seçilen veya numarası girilen mevcut bir kaydın ad ve soyad bilgileri Entity Framework üzerinden sorgulanarak güncellenir.
- **Silme (Delete):** Belirtilen birincil anahtara (`numara`) ait kayıt veritabanından başarıyla silinir ve anlık olarak arayüz yenilenir.
- **Filtreleme / Arama (Search):** İsme göre LINQ sorgusu (`Contains`) kullanılarak harf/kelime bazlı anlık arama yapılır.
- **Hücre Seçimi (Data Binding):** DataGridView üzerinde herhangi bir satıra tıklandığında ilgili satırın sütun verileri otomatik olarak form kutularına aktarılır.

## 🛠 Kullanılan Teknolojiler ve Mimari
- **Programlama Dili:** C# (.NET Framework)
- **Arayüz:** Windows Forms
- **ORM / Veri Erişimi:** Entity Framework (Code-First / DbContext Mapping)
- **Veritabanı:** Microsoft SQL Server (`DESKTOP-63KCJ7O\SQLEXPRESS`)
- **Veritabanı Adı:** `Ray`
- **Tablo:** `dbo.RAYS`
- **Tablo Şeması:**
  - `numara` (PK, nvarchar(50), not null)
  - `Ad` (nvarchar(50), null)
  - `Soyad` (nvarchar(50), null)

## 📂 Sınıf ve Kod Mimarisi
1. **`RAY.cs`:** SQL Server'daki `dbo.RAYS` tablosunu ve sütunlarını C# tarafında temsil eden Model sınıfıdır.
2. **`sanerEntities.cs`:** SQL Server bağlantı dizesini barındıran ve tabloyu `DbSet<RAY>` olarak yöneten `DbContext` sınıfıdır.
3. **`Form1.cs`:** Tüm CRUD (Ekle, Sil, Güncelle, Listele) ve arama işlevlerinin olay metodlarını (Event Handlers) barındıran ana form mantığıdır.
