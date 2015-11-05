DefiniranjeTipa
===============

DefinicijaTipa
--------------
Primjer definicije klase i strukture.

ClassVsStruct
--------------
Usporedba ponašanja klase i strukture.

Internal1 & Internal2
---------------------
Primjer kako pravo pristupa klasi ima utjecaja kod nasljeđivanja.

Internal3
---------
Primjer kako pravo pristupa klasi ima utjecaja kod nasljeđivanja.

UgnjezdjenaKlasa
----------------
(Može se preskočiti!)
U klasi Gnijezdo su ugniježđene dvije klase, jedna sa zaštićenim, a druga s 
privatnim pristupom. Privatna se može pozivati samo iz klase u kojoj je 
ugniježđena, a zaštićena i iz izvedene klase.

StatičkiČlanovi
---------------
Primjer ponašanja statičkog polja i dohvaćanja statičkog člana iz klase i
izvan klase.

Konstruktori
------------
Primjer poziva konstruktora bazne klase pomoću ključne riječi base i 
poziva drugog ("delegiranja") konstruktora iste klase pomoću ključne riječi this.

VirtualneMetode
---------------
Definirana je bazna klasa i iz nje dvije izvedene klase s virtualnim
i nevirtualnim metodama. Kreira se niz objekata pripadajućih tipova i u 
petlji se pozivaju metode. Za virtualne metode će biti uvijek pozvana
metoda iz "najizvedenijeg" tipa! Za nevirtualne metode će uvijek biti
pozvana metoda iz "pretvorenog" (tj. baznog) tipa.

Destruktor
----------
Definirana je klasa s "destruktorom" u kojem se ispisuje poruka u izlazni 
prozor (Output) Visual Studija.
Iako je instanca klase u programu definirana u zasebnom bloku, pri izlasku iz 
bloka se destruktor ne poziva odmah. To čini naknadno tek GC, što se vidi 
po poruci u izlaznom prozoru koja se ispisuje tek nakon što program završi.

GCCollect
---------
U programu generiramo mnoštvo objekata. Ako je broj objekata jako velik,
GC će sam početi uništavati objekte da osigura mjesto za nove.
Iza petlje eksplicitno se poziva GC koji čisti sve nedohvatljive objekte.
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