# NUnit Test

## 📌 Test Tanımlama

- `[Test]`  
  Test metodu tanımlar.

- `[TestCase(...)]`  
  Parametreli test verisi tanımlar.

- `[TestCaseSource(...)]`  
  Test verisini harici bir koleksiyon/metottan alır.

- `[ValueSource(...)]`  
  Parametreleri belirli bir array/list kaynağından alır.

- `[Category("...")]`  
  Testi belirli bir kategoriye etiketler.

- `[Ignore("Sebep")]`  
  Testi atlar, çalıştırmaz.

---

## 📌 Yaşam Döngüsü Anotasyonları

- `[SetUp]`  
  Her test öncesi çalışır.

- `[TearDown]`  
  Her test sonrası çalışır.

- `[OneTimeSetUp]`  
  Test sınıfı başlamadan önce **bir kez** çalışır.

- `[OneTimeTearDown]`  
  Test sınıfı bittikten sonra **bir kez** çalışır.

- `[SetUpFixture]`  
  Namespace kapsamındaki tüm testlerden önce/sonra çalışacak global kurulum/temizlik tanımlar.

---

## 📌 Fixture ve Veri Paylaşımı

- `[TestFixture]`  
  Test sınıfını tanımlar.

- `[Parallelizable]`  
  Testlerin paralel çalıştırılmasını sağlar.

---
