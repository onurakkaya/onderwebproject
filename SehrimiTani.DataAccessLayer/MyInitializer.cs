using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Common;
using System.Data.Entity;
using SehrimiTani.Entities;
using System.Data.Entity.Validation;
using CaracalSoft.Data;

namespace SehrimiTani.DataAccessLayer
{
    public class MyInitializer : CreateDatabaseIfNotExists<DatabaseContext>
    {
        //protected override void Seed(DatabaseContext context)
        //{

        //    List<Sehirler> sehirList = new List<Sehirler>();
        //    for (int i = 0; i < 10; i++)
        //    {
        //        //Şehir Ekleme
        //        Sehirler sehir = new Sehirler()
        //        {

        //            Sehiradi = FakeData.PlaceData.GetCity(),
        //            CreatedOn = DateTime.Now,
        //            ModifiedOn = DateTime.Now,
        //            ModifiedUsername = "ondersahin",


        //        };
        //        sehirList.Add(sehir);
        //        //context.Sehir.Add(sehir);


        //    }
        //    //context.SaveChanges();
        //    Repository<Sehirler>.CreateList(sehirList);

        //    Yorumlar yorum = new Yorumlar();
        //    //Admin Ekleme
        //    List<Kullanicilar> kullaniciListesi = new List<Kullanicilar>();
        //    Kullanicilar admin = new Kullanicilar()
        //    {
        //        Adi = "önder",
        //        Soyadi = "Şahin",
        //        Email = "ondershin@gmail.com",
        //        ActivateGuid = Guid.NewGuid(),
        //        isActive = true,
        //        isAdmin = true,
        //        CreatedOn = DateTime.Now,
        //        ModifiedOn = DateTime.Now.AddMinutes(5),
        //        ModifiedUsername = "ondersahin",
        //        Kuladi = "Onder358",
        //        Sifre = "123456",
        //        Telefon = "5548384350",

        //    };
        //    kullaniciListesi.Add(admin);

        //    //Kullanıcı oluşturma

        //    Kullanicilar standartUser = new Kullanicilar()
        //    {
        //        Adi = "Ahmet",
        //        Soyadi = "Şahin",
        //        Email = "ahmet@gmail.com",
        //        ActivateGuid = Guid.NewGuid(),
        //        isActive = true,
        //        isAdmin = false,
        //        CreatedOn = DateTime.Now,
        //        ModifiedOn = DateTime.Now.AddMinutes(5),
        //        ModifiedUsername = "ondersahin",
        //        Kuladi = "Onder358",
        //        Sifre = "123456",
        //        Telefon = "05548384350",

        //    };

        //    kullaniciListesi.Add(standartUser);
        //    //Kullanıcılar oluşturma 
        //    for (int i = 0; i < 8; i++)
        //    {
        //        Kullanicilar user = new Kullanicilar()
        //        {
        //            Adi = FakeData.NameData.GetFirstName(),
        //            Soyadi = FakeData.NameData.GetSurname(),
        //            Email = FakeData.NetworkData.GetEmail(),
        //            ActivateGuid = Guid.NewGuid(),
        //            isActive = true,
        //            isAdmin = false,
        //            CreatedOn = FakeData.DateTimeData.GetDatetime(DateTime.Now.AddYears(-1), DateTime.Now),
        //            ModifiedOn = FakeData.DateTimeData.GetDatetime(DateTime.Now.AddYears(-1), DateTime.Now),
        //            ModifiedUsername = $"user{i}",
        //            Kuladi = $"user{i}",
        //            Sifre = "123",
        //            Telefon = "5548384350",


        //        };
        //        kullaniciListesi.Add(user);

        //    }
        //    Repository<Kullanicilar>.CreateList(kullaniciListesi);

        //    //try
        //    //{
        //    //    // Your code...
        //    //    //context.SaveChanges();
        //    //}
        //    //catch (DbEntityValidationException e)
        //    //{
        //    //    foreach (var eve in e.EntityValidationErrors)
        //    //    {

        //    //        foreach (var ve in eve.ValidationErrors)
        //    //        {
        //    //            /*Console.WriteLine("- Property: \"{0}\", Error: \"{1}\"",
        //    //                ve.PropertyName, ve.ErrorMessage);*/


        //    //            string a = ve.PropertyName;
        //    //            string b = ve.ErrorMessage;

        //    //        }
        //    //    }
        //    //    throw;
        //    //}






        //    List<Universite> universiteListesi = new List<Universite>();

        //    Sehirler gSehir = Repository<Sehirler>.Read(x => x.Id == 1);
        //    //Fake dabase universite ekleme
        //    for (int i = 0; i < 10; i++)
        //    {
        //        //Üniversite Ekleme
        //        Universite uni = new Universite()
        //        {
        //            adi = FakeData.PlaceData.GetCity(),
        //            Icerik = FakeData.PlaceData.GetAddress(),
        //            CreatedOn = DateTime.Now,
        //            ModifiedOn = DateTime.Now,
        //            ModifiedUsername = "ondersahin",
        //            SehirID = gSehir
        //        };

        //        universiteListesi.Add(uni);
        //    }
        //    Repository<Universite>.CreateList(universiteListesi);
        //    //context.Universiteler.Add(uni);

        //    //context.SaveChanges();

        //    Barinma barinma = new Barinma()
        //    {
        //        Adres = FakeData.PlaceData.GetAddress(),
        //        CreatedOn = FakeData.DateTimeData.GetDatetime(DateTime.Now.AddYears(-1), DateTime.Now),
        //        ModifiedOn = FakeData.DateTimeData.GetDatetime(DateTime.Now.AddYears(-1), DateTime.Now),
        //        Icerik = FakeData.TextData.GetSentence(),
        //        ModifiedUsername = "ondersahin",
        //        Tipi = "Yurt",
        //        SehirID = gSehir
        //    };
        //    Repository<Barinma>.Create(barinma);
        //    //Yorumlar 
        //    List<Yorumlar> yorumListesi = new List<Yorumlar>();
        //    for (int k = 0; k < FakeData.NumberData.GetNumber(5, 9); k++)
        //    {
        //        yorum = new Yorumlar()
        //        {
        //            Icerik = FakeData.TextData.GetSentence(),
        //            LikeCount = FakeData.NumberData.GetNumber(1, 9),
        //            Owner = (k % 2 == 0) ? admin : standartUser,
        //            CreatedOn = FakeData.DateTimeData.GetDatetime(DateTime.Now.AddYears(-1), DateTime.Now),
        //            ModifiedOn = FakeData.DateTimeData.GetDatetime(DateTime.Now.AddYears(-1), DateTime.Now),
        //            ModifiedUsername = (k % 2 == 0) ? admin.Kuladi : standartUser.Kuladi,
        //            SehirlerID = gSehir

        //        };

        //        yorumListesi.Add(yorum);
        //    }
        //    Repository<Yorumlar>.CreateList(yorumListesi);

        //    List<Kullanicilar> userlist = Repository<Kullanicilar>.ReadList();
        //    //Liked adding..
        //    List<Liked> likesList = Repository<Liked>.ReadList();
        //    for (int j = 0; j < yorum.LikeCount; j++)
        //    {
        //        Liked liked = new Liked()
        //        {
        //            LikedUser = userlist[j],
        //        };

        //        likesList.Add(liked);
        //    }

        //    Repository<Liked>.CreateList(likesList);


        //    //Gezilecek yer ekleme
        //    List<Gezilecekyer> geziList = Repository<Gezilecekyer>.ReadList();
        //    for (int m = 0; m < FakeData.NumberData.GetNumber(5, 9); m++)
        //    {
        //        Gezilecekyer gezilecekyer = new Gezilecekyer()
        //        {
        //            Baslik = "Vizelerden Sonra Güzel Bir Sessizlik",
        //            CreatedOn = FakeData.DateTimeData.GetDatetime(DateTime.Now.AddYears(-1), DateTime.Now),
        //            ModifiedOn = FakeData.DateTimeData.GetDatetime(DateTime.Now.AddYears(-1), DateTime.Now),
        //            Icerik = FakeData.TextData.GetSentence(),
        //            ModifiedUsername = "ondersahin",
        //            Resim = "image/man.jpg",
        //            SehirlerID = gSehir

        //        };
        //        //context.Gezilecekyerler.Add(gezilecekyer);
        //        geziList.Add(gezilecekyer);

        //    }
        //    Repository<Gezilecekyer>.CreateList(geziList);

        //    //Puan ekleme
        //    List<Puan> puanList = Repository<Puan>.ReadList();

        //    for (int m = 0; m < FakeData.NumberData.GetNumber(5, 9); m++)
        //    {
        //        Puan puan = new Puan()
        //        {
        //            degerler = FakeData.NumberData.GetNumber(1, 10),
        //            CreatedOn = FakeData.DateTimeData.GetDatetime(DateTime.Now.AddYears(-1), DateTime.Now),
        //            ModifiedOn = FakeData.DateTimeData.GetDatetime(DateTime.Now.AddYears(-1), DateTime.Now),
        //            ModifiedUsername = "ondersahin",
        //            UniversiteID = Repository<Universite>.Read(x => x.Id == 1)
        //        };
        //        // context.puanlar.Add(puan);
        //        puanList.Add(puan);
        //    }
        //    Repository<Puan>.CreateList(puanList);

        //    //Yemekler EKleme
        //    List<Yemekler> yemeklerList = Repository<Yemekler>.ReadList();
        //    for (int m = 0; m < FakeData.NumberData.GetNumber(5, 9); m++)
        //    {
        //        Yemekler yemekler = new Yemekler()
        //        {
        //            Icerik = FakeData.TextData.GetSentence(),
        //            SehirID = gSehir,


        //        };

        //        //context.Yemek.Add(yemekler);
        //        yemeklerList.Add(yemekler);
        //    }
        //    Repository<Yemekler>.CreateList(yemeklerList);

        //}
    }
}
