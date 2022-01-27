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
* <strong> L: Liskov Substitution Principle (LSP) </strong>
Liskov Substitution Principle’a göre alt sınıflardan oluşturulan nesnelerin üst sınıfların nesneleriyle yer değiştirdiklerinde aynı davranışı göstermek zorundadır. Yani; türetilen sınıflar, türeyen sınıfların tüm özelliklerini kullanmak zorundadır. 

Aşağıdaki kodda Striker aslında ihtiyaç duymadığı KeepTheBall metodunu barındırmakta yani bir forvet oyuncusu topu eliyle tutamaz. Normal şartlarda bu fonksiyonu kullanamayacak, bu fonksiyonda exception fırlatması gerekecektir. Yani aslında gereksiz bir kod kalabalığı ve kod yönetimi açısından ek bir efor oluşacaktır, bunun nedeni base classda aslında gereksiz bir metod bulunmasıdır. 

```
public abstract class Player
    {
        public virtual void KickTheBall()
        {
            // Ball was kicked !
        }

        public virtual void KeepTheBall()
        {
            // Ball was kept !
        }
    }

    public class Striker : Player
    {
        public override void KeepTheBall()
        {
            // Striker should not keep the ball !
            throw new NotImplementedException();
        }

        public override void KickTheBall()
        {
            // Ball was kicked by Striker !
        }
    }

    public class Goalkeeper : Player
    {
        public override void KeepTheBall()
        {
            // Ball was kept by Goalkeeper!
        }

        public override void KickTheBall()
        {
            // Ball was kicked by Goalkeeper !
        }
    }
  ```

Bu ayrıştırmayı yapmak için aşağıdaki gibi bir kodlama yapmalıyız.

```
	public abstract class Player
    {
        public virtual void KickTheBall()
        {
            // Ball was kicked !
        }
    }

    public interface IKeepTheBall
    {
        void KeepTheBall();
    }

    public class Striker : Player
    {
        public override void KickTheBall()
        {
            // Ball was kicked by Striker !
        }
    }

    public class Goalkeeper : Player,IKeepTheBall
    {
        public override void KickTheBall()
        {
            // Ball was kicked by Goalkeeper !
        }

        public void KeepTheBall()
        {
            // Ball was kept by Goalkeeper !
        }
    }
 ```
 * <strong> I:  Interface Segregation Principle (ISP) </strong>
 Interface Segregation prensibine göre, her interface’in belirli bir amacı olmalıdır. Tüm metodları kapsayan tek bir interface kullanmak yerine, herbiri ayrı metod gruplarına hizmet veren birkaç interface tercih edilmektedir.

Aşağıdaki interface birden fazla iş yapmaktadır. Bu arayüzden türetilen sınıflar tüm metodları kullanmak zorunda kalacaktır. Bunun yerine bu arayüzler daha küçük iş birimlerine ayrılmalıdır.

```
	interface IPost
    {
        void CreatePost();
        void ReadPost();
    }
```

Küçük parçalara ayrılmış interface’ler sınıflara daha kolay eklenirler. Bu sayede bu arayüzlerden türetilen sınıflar kullanmadıkları metodları almamış olurlar.

```
    interface IPostCreate
    {
        void CreatePost();
    }

    interface IPostRead
    {
        void ReadPost();
    }
```

* <strong> D: Dependency Inversion Principle (DIP) </strong>

Robert C. Martin’in Dependency Inversion Prensibi’ne göre:

1. Üst seviye (High-Level) sınıflar, alt seviye (Low-Level) sınıflara bağlı olmamalıdır, ilişki abstraction veya interface kullanarak sağlanmalıdır,
2. Abstraction(soyutlama) detaylara bağlı olmamalıdır, tam tersi detaylar abstraction(soyutlama)’lara bağlı olmalıdır.

Aşağıdaki Blog sınıfı içerisindeki Create metodu, Post sınıfı içerisindeki CreatePost isimli metoda bağımlıdır. Bunun sebebi CreatePost method’unun Create içerisinde kullanılmasıdır. Bu metotda yapılacak tüm değişiklikler Create method’unda da değişiklik gerektirecektir.


```
    class Blog
    {
        // High Level Class
        public void Create()
        {
            Post post = new Post();
            post.CreatePost(true);
        }
    }

    class Post
    {
        // Low Level Class
        public void CreatePost(bool picture)
        {
            // Process
        }
    }
```

Bu bağımlılıktan kurtulabilmek için aşağıdaki kodu uygulayabiliriz.

```
    interface IContent
    {
        void CreatePost(bool picture);
    }

    class Blog
    {
        //High Level Class
        IContent content;
        public Blog()
        {
            content = new Post();
        }
        public void Create()
        {
            content.CreatePost(true);
        }
    }

    class Post : IContent
    {
        //Low Level Method
        public void CreatePost(bool picture)
        {
            //Process
        }
    }
```

Yapılan işlem neticesinde alt seviye sınıfı olan Post, Interface sayesinde soyutlaştırılarak, üst seviye sınıfımızda alt seviye sınıfına dair olan bağımlılığı tersine çevirmiş bulunmaktayız. Yani alt seviye sınıf olan Post, Interface’e bağımlı bir hale gelmiştir.
