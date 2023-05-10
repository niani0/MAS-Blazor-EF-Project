public class Tartacznik {
    private int staż;
    private float pensja;
    private GrupaTartaczników grupaTartaczników;

    private Tartacznik(int staż, float pensja,GrupaTartaczników grupaTartaczników) {
        this.staż = staż;
        this.pensja = pensja;
        this.grupaTartaczników = grupaTartaczników;
    }

    public static Tartacznik createTartacznik(GrupaTartaczników grupa, int staż, float pensja) throws Exception{
        if (grupa == null) {
            throw new Exception("Grupa nie istnieje");
        }
        Tartacznik tartacznik = new Tartacznik(staż,pensja,grupa);
        grupa.dodajTartacznika(tartacznik);
        return tartacznik;
    }


}
