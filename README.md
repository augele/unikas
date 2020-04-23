# unikas

V0.1  https://github.com/augele/unikas/tree/2eaf539ce6b291f3a17347158ebc1f9bb4ab44f2 
programa nuskaito studentus iš konsolės, kai namų darbų skaičius yra nežinomas, o paskutinis balas - egzamino balas. Skaičiuoja vidurkį bei teisingai išveda studentų sąrašą į konsolės langą. Viskas saugoma List<Studentas>.

V0.2  [https://github.com/augele/unikas/tree/94a5847365eddbc6d7afe451ddd47d4548f68634]
programa paklausia , ar norite nuskaityti studentus iš failo ar įvesti ranka, viską saugo List <Studentas>, suskaičiuoja vidurkį bei išveda surušiuotus pagal vardą į konsolę.

V0.3  [https://github.com/augele/unikas/commit/8950e5d2c703ab989b878a659c6c5961db9519e5]
nuo v0.2 - atskirta studentas klasė į atskirą failą, šiektiek pagražinta kodo kultūra, pridėtas try catch

V0.4  [https://github.com/augele/unikas/commit/89c6aeef0060a97e07ce44cea00d89194c7fa8b1]
generuoja šabloninį studentų sąrašą su random balais ir įrašo į failą, kurio pavadinimas priklauso nuo norimo generavimo dydžio. tuomet nuskaitomas failas ir pagal vidurkius surušiuojama į du naujus List<Studentas> ir atitinkamai listai išvedami į naujus failus. atlikta spartos analizė naudojant stopwatch.

V0.5  [https://github.com/augele/unikas/commit/ebd2adf106a2524cd4697a6b18ccaa4086a07a0a]
Pamuotas 0.4 programos greitis naudojant skirtingus konteinerių tipus, viskas išvedama į failą bei į konsolę .

V1.0  [https://github.com/augele/unikas/commit/f6a9709bc8e7041e8059388aad356429333d4af1]
naudotos 2 strategijos aprasytos rezultatu faile(tačiau ne su visais konteineriais)
susikelus visus failus ir paleidus, konsoles lange gaunat rezultatus, kurie irasomi į rezultatai.txt faila.
naudotas 100000 įrašų sugeneruotas studentų failas (susikuria automatiskai) rezultatai išreikšti ms(milisekundemis)
1 strategija List naudojant remove all metoda uztruko 12,8227
1 strategija List naudojant cikla for uztruko 60,0399
2 strategija List sukuriant vargsiukus ir paliekant pagrindiniame konteineryje tik kietekus uztruko 12,9208
1 strategija Linked list pridedant i prieki uztruko 31,232400000000002
1 strategija Linked list pridedant i gala uztruko 39,9925
1 strategija Linkedlist for ciklu popinant is steko itemus uztruko 86,696
1 strategija Queue naudojant enqueue uztruko 21,7297
1 strategija Queue naudojant dequeue uztruko 38,495799999999996
Kompiuterio parametrai
i5 7200u
8gb ddr3 ram
500gb kietasis diskas
