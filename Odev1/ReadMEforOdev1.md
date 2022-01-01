## Odev 1
Ogrenciler listesine ekleme, silme, guncelleme yapabiliriz. Listede tek bir ogrencini ya da butun ogrencilerin listesini görüntüleyebiliriz.
Ögrenciler calss'ı
  * StudentId
  * Name
  * Surname
  * Age
değişkenlerinden oluşmaktadır.
 
### GET
#### İdsi ile istediğimiz öğrencinin bilgisini görebiliriz
```
http://localhost:5042/StudentsOperations/1
```
#### Bütün öğrencilerin listesini görüntüleyebiliriz
```
http://localhost:5042/StudentsOperations
```
### POST
#### Yeni öğrenci ekleyebiliriz

### PUT
#### Idsini  verdigimiz ogrencilerin bilgilerini yeni girdigimiz bilgilerle degistirebiliriz.

### DELETE
#### Ogrencinin idsini girerek bilgilerini listeden silebiliriz.

