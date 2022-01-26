# Odev 5
Create Token islemini Odev4 dosyasi icinde <strong> AuthController.cs </strong> dosyasi altinda gerceklestirdim.
* Kullanicin kullanici adi  ve sifresi icin yeni bir <strong> APIAuthority </strong> adinda tablo olusturdum.
![image](https://user-images.githubusercontent.com/60337657/151193460-e7a4c519-1922-416d-85ac-10793be89cbd.png)
* Tablo modelini de Model=>Login.cs icinde tutuyorum:
![image](https://user-images.githubusercontent.com/60337657/151193629-f7268c0c-57a3-40fa-9b65-39bf80f32dcf.png)
* Veri tabanina baglanma kismini Entities=>StudentContext.cs classina eklemeler yaparak tamamladim
  ```
     protected override void OnModelCreating(ModelBuilder modelBuilder)
     {
      ...
        modelBuilder.Entity<APIAuthority>().ToTable("APIAuthority");
     }
  ```
  ```
      public DbSet<APIAuthority> APIAuthority { get; set;}
  ```
 * Karmaşa olmaması adına Login bilgilerini veritabanına ekleme ve veritabanından çekme işlemleri için yeni bir
 <strong> LoginDbOperations.cs  </strong> adinda bir class olusturup orda yazdim. Bu classın içinde 
    * CreateLogin
    * GetLogin
fonksiyonları bulunmaktadır.
