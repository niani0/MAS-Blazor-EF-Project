import java.time.LocalDate;

public class Main {
    public static void main(String[] args) {
        asocjacjaZwykła();
        asocjacjaZAtrybutem();
        asocjacjaKwalifikowana();
        try {
            kompozycja();
        } catch (Exception e) {
            throw new RuntimeException(e);
        }
    }
    public static void asocjacjaZwykła(){
        System.out.println("Asocjacja zwykła (Zadania(*) - (*)Materiały)");
        Zadanie z1 = new Zadanie("Przyjęte", LocalDate.now(), LocalDate.now());
        Zadanie z2 = new Zadanie("Anulowane", LocalDate.now(), LocalDate.now());
        Materiał m1 = new Materiał("Drewno", 2.5f);
        Materiał m2 = new Materiał("Złoto", 50.5f);
        z1.dodajMateriał(m1);
        z1.dodajMateriał(m2);
        m2.dodajZadanie(z2);
        System.out.println(z1);
        System.out.println(z2);
        System.out.println();
    }
    public static void asocjacjaZAtrybutem(){
        System.out.println("Asocjacja z atrybutem (Kierownik(1) - (1)Raport(*) - (1)Zadania)");
        Zadanie z1 = new Zadanie("Przyjęte", LocalDate.now(), LocalDate.now());
        Zadanie z2 = new Zadanie("Anulowane", LocalDate.now(), LocalDate.now());
        RaportZZadania r1 = new RaportZZadania("r1",LocalDate.now(),"opis");
        RaportZZadania r2 = new RaportZZadania("r2",LocalDate.now(),"opis");
        r1.setZadanie(z1);
        r2.setZadanie(z1);
        Kierownik k1 = new Kierownik("032123112");
        r1.setKierownik(k1);
        System.out.println(r1);
        System.out.println();
    }
    public static void asocjacjaKwalifikowana (){
        System.out.println("Asocjacja Kwalifikowana");
        GrupaTartaczników g1 = new GrupaTartaczników("drewno");
        GrupaTartaczników g2 = new GrupaTartaczników("złoto");

        Zadanie z1 = new Zadanie("Przyjęte", LocalDate.now(), LocalDate.now());
        Zadanie z2 = new Zadanie("Anulowane", LocalDate.now(), LocalDate.now());
        Zadanie z3 = new Zadanie("Anulowane", LocalDate.now(), LocalDate.now());

        z1.addGrupaTartaczników(g1);
        z1.addGrupaTartaczników(g2);
        z2.addGrupaTartaczników(g1);
        z3.addGrupaTartaczników(g2);

        System.out.println(z1);
        System.out.println(z2);
        System.out.println(z3);

        try {
            System.out.println(z1.znajdzGrupeTartacznikow("drewno"));
        } catch (Exception e) {
            throw new RuntimeException(e);
        }
//        try {
//            System.out.println(z1.znajdzGrupeTartacznikow("costam"));
//        } catch (Exception e) {
//            throw new RuntimeException(e);
//        }
        System.out.println();
    }
    public static void kompozycja () throws Exception {
        System.out.println("Kompozycja Tartacznik - GrupaTartaczników");
        GrupaTartaczników g1 = new GrupaTartaczników("drewno");
        GrupaTartaczników g2 = new GrupaTartaczników("złoto");
        Tartacznik t1 = Tartacznik.createTartacznik(g1,13,1250f);
        Tartacznik t2 = Tartacznik.createTartacznik(g1,13,1250f);
        System.out.println(g1);
//        g2.dodajTartacznika(t1);
        System.out.println();
    }
}