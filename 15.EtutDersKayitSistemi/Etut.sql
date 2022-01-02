Create procedure Etut 
as
select EtutID,DersAd, (Ogretmenler.OgretmenAd + ' ' + Ogretmenler.OgretmenSoyad) as 'Ogretmen', (Ogrenciler.OgrenciAd + ' ' + Ogrenciler.OgrenciSoyad) as 'Ogrenci', EtutTarih, EtutSaat from Etutler 
inner join Dersler on Etutler.DersID = Dersler.DersID 
inner join Ogretmenler on Etutler.OgretmenID = Ogretmenler.OgretmenID
inner join Ogrenciler on Etutler.OgrenciID = Ogrenciler.OgrenciID
