# 🎓 Burs Bulma Sistemi

![Durum](https://img.shields.io/badge/Durum-Aktif-success.svg)
![Dil](https://img.shields.io/badge/Dil-C%23-blue.svg)
![Platform](https://img.shields.io/badge/Platform-Windows%20Forms-lightgrey.svg)

**Burs Bulma Sistemi**, üniversite öğrencilerinin kendilerine uygun bursları kolayca bulup başvurabilmelerini; kurumların ise burs ilanı verip başvuruları yönetebilmelerini sağlayan bir Windows Forms masaüstü uygulamasıdır.

---

## 📋 İçindekiler
- [Proje Hakkında](Üniversite öğrencilerinin eğitim hayatlarını sürdürürken maddi destek bulma süreçleri genellikle dağınık, yorucu ve karmaşıktır. Öğrenciler yüzlerce farklı web sitesini gezmek zorunda kalırken, burs veren kurumlar da hedefledikleri kriterlere sahip doğru öğrencilere ulaşmakta güçlük çekebilirler.

**Burs Bulma Sistemi**, bu iletişim kopukluğunu gidermek ve iki tarafı tek bir dijital platformda buluşturmak amacıyla geliştirilmiştir. 

Bu projenin temel hedefleri şunlardır:
* **Erişilebilirlik:** Öğrencilerin, akademik başarılarına (YKS sıralaması, not ortalaması) ve maddi durumlarına (gelir düzeyi) en uygun bursları saniyeler içinde filtreleyip bulabilmelerini sağlamak.
* **Kolay Yönetim:** Burs veren kurumların (Vakıflar, Dernekler, Şirketler) ilanlarını kolayca yayınlamasını ve gelen başvuruları tek bir panel üzerinden düzenli bir şekilde görüntülemesini sağlamak.
* **Verimlilik:** Başvuru süreçlerini dijitalleştirerek kağıt israfını önlemek ve zaman kaybını en aza indirmek.

Teknik olarak proje; **C#** programlama dili ve **Windows Forms** altyapısı kullanılarak, **Nesne Yönelimli Programlama (OOP)** prensiplerine uygun, modüler ve geliştirilebilir bir mimaride tasarlanmıştır. Mevcut sürümde veriler uygulama yaşam döngüsü boyunca **bellek üzerinde (In-Memory)** tutularak hızlı bir prototip deneyimi sunulmaktadır.)

## 🚀 Proje Hakkında
Bu proje, burs arama süreçlerindeki dağınıklığı ve karmaşıklığı azaltmak amacıyla geliştirilmiştir. Sistem iki ana kullanıcı tipine hitap eder: **Öğrenciler** ve **Kurumlar**. 

Veriler şu an için uygulama açık kaldığı sürece **RAM üzerinde (Statik Listeler)** tutulmaktadır. Kullanıcı dostu arayüzü sayesinde öğrenciler; başarı sıralaması, not ortalaması ve gelir durumu gibi kriterlere göre filtrelenmiş bursları listeleyebilir ve tek tıkla başvuru yapabilirler.

---

## ✨ Özellikler

### 👨‍🎓 Öğrenci Paneli
* **Kayıt & Giriş:** TC Kimlik No ve şifre ile güvenli giriş sistemi.
* **Profil Yönetimi:** Kişisel bilgiler, okul, bölüm, not ortalaması ve iletişim bilgilerini güncelleme.
* **Akıllı Burs Arama:** "Burs Ara" modülü ile öğrencinin kriterlerine (gelir, başarı sırası vb.) uygun bursların otomatik listelenmesi.
* **Başvuru Sistemi:** Listelenen burslara anında başvuru yapabilme.
* **Favoriler:** İlgilenilen bursları daha sonra incelemek üzere favorilere ekleme.
* **Başvuru Geçmişi:** Yapılan başvuruların tarihini ve detaylarını görüntüleme.

### 🏢 Kurum Paneli
* **Kurumsal Profil:** Kurum adı ve iletişim bilgilerini düzenleme.
* **Burs İlanı Oluşturma:** Burs adı, şehir, son başvuru tarihi ve başvuru şartlarını (Min. Not, Max. Gelir vb.) belirleyerek ilan yayınlama.
* **Başvuru Yönetimi:** Kurumun açtığı ilanlara gelen öğrenci başvurularını tek listede görüntüleme.

---

## 📸 Ekran Görüntüleri

| Giriş Ekranı | Öğrenci Paneli |
| :---: | :---: |
| <img src="https://github.com/user-attachments/assets/2655a6e9-d772-47b1-9cf6-0fc4681254c0" width="100%" /> | <img src="https://github.com/user-attachments/assets/635d8220-452c-4d1e-aca0-49ba79df3428" width="100%" /> |

| Kurum Paneli | Burs Arama |
| :---: | :---: |
| <img src="https://github.com/user-attachments/assets/4a70803f-e7f2-4019-b42c-63fe3e230d14" width="100%" /> | <img src="https://github.com/user-attachments/assets/90ad77c3-3895-430d-ab56-6cadc4fc8bc8" width="100%" /> |

---

## 🛠 Teknolojiler

Bu proje aşağıdaki araçlar ve diller kullanılarak geliştirilmiştir:

* **Programlama Dili:** C# (.NET 8.0)
* **Arayüz:** Windows Forms (WinForms)
* **IDE:** Visual Studio 2022
* **Veri Yapısı:** Nesne Tabanlı Programlama (OOP) - Statik Sınıflar ve Listeler

---

## 💻 Kurulum ve Çalıştırma

Projeyi bilgisayarınızda çalıştırmak için şu adımları izleyin:

1.  **Projeyi İndirin:**
    Bu sayfadan ZIP olarak indirebilir veya aşağıdaki komutla klonlayabilirsiniz:
    ```bash
    git clone [https://github.com/kullaniciadi/burs-bulma-sistemi.git](https://github.com/kullaniciadi/burs-bulma-sistemi.git)
    ```
2.  **Visual Studio ile Açın:**
    `projeburs.sln` dosyasını Visual Studio 2022 ile açın.
3.  **Projeyi Derleyin:**
    Üst menüden `Build` > `Build Solution` (veya `CTRL + SHIFT + B`) diyerek projeyi derleyin.
4.  **Çalıştırın:**
    `Başlat` butonuna veya `F5` tuşuna basarak uygulamayı çalıştırın.

---

## 🏗 Proje Mimarisi

Proje, temiz kod ve **OOP (Nesne Yönelimli Programlama)** prensipleri üzerine kurgulanmıştır.

* **VeriYoneticisi.cs:** Tüm verilerin merkezi olarak yönetildiği statik sınıftır.
* **Sınıflar (Classes):**
    * `Ogrenci`: Öğrenci özelliklerini ve metotlarını barındırır.
    * `Kurum`: Kurum bilgilerini tutar.
    * `Burslar`: Burs ilan detaylarını içerir.
    * `Basvuru`: Öğrenci ve Burs arasındaki başvuru kaydını tutar.
* **Formlar:**
    * `Form1`: Giriş Ekranı
    * `Form2`: Kayıt Ekranı
    * `Form3`: Öğrenci İşlemleri Paneli
    * `Form4`: Kurum İşlemleri Paneli

---

## 🔮 Gelecek Güncellemeler (To-Do)

- [ ] Verilerin kalıcı olması için **SQL Veritabanı** entegrasyonu.
- [ ] Şifreleme algoritmaları ile güvenli giriş.
- [ ] Yönetici (Admin) paneli eklenmesi.
- [ ] Gelişmiş filtreleme seçenekleri (Bölüm ve Şehir bazlı detaylı arama).
- [ ] Başvuruları Onayla/Reddet mekanizması.

---

