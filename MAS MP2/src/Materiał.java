import java.util.ArrayList;
import java.util.List;

public class Materiał {
    private String nazwa;
    private float cenaZaKilogram;
     private List<Zadanie> zadania = new ArrayList<>();

    public Materiał(String nazwa, float cenaZaKilogram) {
        this.nazwa = nazwa;
        this.cenaZaKilogram = cenaZaKilogram;
    }

    public void dodajZadanie(Zadanie noweZadanie) {
        if(!zadania.contains(noweZadanie)) {
            zadania.add(noweZadanie);
            noweZadanie.dodajMateriał(this);
        }
    }

    public String getNazwa() {
        return nazwa;
    }

    public float getCenaZaKilogram() {
        return cenaZaKilogram;
    }

    public List<Zadanie> getZadania() {
        return zadania;
    }

    @Override
    public String toString() {
        StringBuilder info = new StringBuilder("Materiał: " +
                "nazwa='" + nazwa + '\'' +
                ", cenaZaKilogram=" + cenaZaKilogram + "\n");

        for (Zadanie z: zadania) {
            info.append("    ").append(z.getStan());
        }
        return info.toString();
    }
}
