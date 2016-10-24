DefiniranjeTipa
===============

KorištenjeTipa
--------------
Primjer stvaranja instanci i korištenja objekta i njegovih članova.


DefinicijaTipa
--------------
Primjer definicije klase i strukture.


Class-Struct
--------------
Usporedba ponašanja klase i strukture.


Internal1 & Internal2
---------------------
Primjer kako pravo pristupa klasi ima utjecaja kod nasljeđivanja.


UgnježđenaKlasa
---------------
Primjer prava pristupa ugnježđenim klasama.


StatičkiČlanovi
---------------
Primjer ponašanja statičkog polja i dohvaćanja statičkog člana iz klase i
izvan klase.


KonstruktorKlase
----------------
Primjer definicije i poziva konstruktora klase.


KonstruktorStrukture
--------------------
Primjer definicije i poziva konstruktora strukture.


DelegiranjeKonstruktora
-----------------------
Primjer poziva konstruktora bazne klase pomoću ključne riječi base i 
poziva drugog ("delegiranja") konstruktora iste klase pomoću ključne riječi this.


VirtualneMetode
---------------
Primjer ponašanja virtualnih i nevirtualnih metoda u izvedenim klasama.


VirtualneMetodeKonstruktor
--------------------------
Primjer kako se iz konstruktora mogu pozivati virtualne metode.


Destruktor
----------
Primjer koji pokazuje kada se (ne) poziva destruktor, tj. finalizirajuća metoda.


GCCollect
---------
Primjer kako se pomoću GC.Collect može forsirati oslobađanje memorije.
Treba primijetiti da resdoslijed uništavanja objekata nema izravne veze s
redoslijedom njihova stvaranja.


IDisposable0
------------
Klasa koja radi s datotekom zatvara datoteku u destruktoru. Budući da
destruktor može biti pozvan i nakon završetka programa, pokušaj brisanja 
datoteke u programu će baciti iznimku.


IDsisposable1
-------------
Klasa za rad s datotekom implementira IDisposable sučelje što omogućava da
eksplicitno pozovemo Dispose metodu (ili koristimno blok using) prije
brisanja datoteke.