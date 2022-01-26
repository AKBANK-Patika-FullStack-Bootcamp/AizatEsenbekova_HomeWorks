![image](https://user-images.githubusercontent.com/60337657/151159277-79e79378-9512-4291-b3d9-4bdb32f2a2b2.png)

SOLID prensipleri: geliştirilen herhangi bir yazılımın esnek, yeniden kullanılabilir, sürdürülebilir ve anlaşılır olmasını sağlayan, ayrıca kod tekrarını önleyen prensiplerdir. 
Kodun esnek, sürdürülebilir ve geliştirilebilir tasarlanmaması kodu kırılganlaştırır ve yazılım ürününün gelişmesini etkiler. SOLID 5 farklı prensipten oluşur ve her birini baş
harfini alır.

SOLID Prensipleri :
* <strong> S : Single Responsibility Principle (SRP) </strong>
  Single Responsibility Principle’a göre, her method ve class’ın tek bir görevi ve sorumluluğu vardır.
Aşağıdaki “Customer” class yapısını incelersek bu class yapısı içerisinde Customer oluşturan bir fonksiyon var. Ayrıca oluşturulan kullanıcıyı dosyaya kaydetmek için oluşturulmuş ayrı bir fonksiyon daha var. 
Bu class yapısı 2 farklı sorumluluk alıyor, biri Customer oluştururken, diğeri ise dosyaya yazma işlemi yapıyor. Customer sınıfı, dosyaya kaydetme sorumluluğunu üstlenmemelidir.
```
public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public void CreateCustomer(Customer customer)
        {
            // Customer created !
        }

        public void SaveToFile(Customer customer)
        {
            // Customer saved to file !
        }
    }
```
SRP’ye göre bir class sadece bir sorumluluk almalı. Bu yüzden SaveToFile fonksiyonunu File isminde bir class oluşturarak oraya aktarıyoruz. 
Böylelikle 2 ayrı işi birbirinden ayırmış oluyoruz. Kodumuzu aşağıdaki gibi düzenlememiz gerekiyor.

```
public class File
    {
        public void SaveToFile(Customer customer)
        {
            // Customer saved to file !
        }
    }
```
* <strong>  O : Open Closed Principle (OSP) </strong>
  Open Closed Principle’a göre her class geliştirmeye açık olmalı fakat değişime kapalı olmadılır.
Aşağıdaki class yapısını incelediğimizde hangi dosya türüne kaydedilmek isteniyorsa her dosya türü için bir if bloğu yazıyoruz ancak bu 
kodumuzda kötü bir görünüme sebep oluyor.

```
public class File
    {
        public void SaveToFile(Customer customer)
        {
            if (TypeOfFile == "txt")
            {
                // Save to txt file !
            }

            if (TypeOfFile == "xls")
            {
                // Save to xls file !
            }

            // ... and more file types
        }
    } 
 ```
  
    Bu nedenle bu prensibe uymak için kodumuzu aşağıdaki gibi düzenlememiz gerekiyor. 
    
  
```	
  abstract class File
    {
        public abstract void SaveToFile(Customer customer);
    }


    class TxtFile : File
    {
        public override void SaveToFile(Customer customer)
        {
            // Saved to txt file !
        }
    }
    

    class XlsFile : File
    {
        public override void SaveToFile(Customer customer)
        {
            // Saved to xls file !
        }
    }
  ```
    
  Dolayısıyla, yeni bir dosya türüne kaydetmek istiyorsak, sadece File class yapısından Inheritance işlemi uygularız. Sonuç olarak File class yapısı gelişime açık fakat değişiklik için kapalıdır.
