using Observer_Muster;


Auto_Versicherung Premium = new Auto_Versicherung();
IKunde Ork_General = new Ork_General();
Ork_General.NameEingeben();
IKunde Ork_Soldat = new Ork_Soldat();
Ork_Soldat.NameEingeben();

Premium.KundeHinzufügen(Ork_General);
Premium.KundeHinzufügen(Ork_Soldat);

Formular new_Formular = new Formular("Auto_Pannen_Transport");
Premium.setFormular(new_Formular);
Premium.getKunden();

Premium.KundeEntfernen(Ork_Soldat);

Premium.getKunden();





Console.ReadKey();