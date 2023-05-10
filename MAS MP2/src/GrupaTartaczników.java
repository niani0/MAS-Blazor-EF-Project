import java.util.*;

public class GrupaTartaczników {
    private String specjalizacja;

    private List<Tartacznik> tartacznicy = new ArrayList<>();
    private static Set<Tartacznik> wszyscyTartacznicy = new HashSet<>();
    private List<Zadanie> zadania = new ArrayList<>();

    public GrupaTartaczników(String specjalizacja) {
        this.specjalizacja = specjalizacja;
    }
    public void dodajTartacznika(Tartacznik tartacznik) throws Exception {
        if(!tartacznicy.contains(tartacznik)){
            if (wszyscyTartacznicy.contains(tartacznik)){
                throw new Exception("Tartacznik jest już połączony z grupą");
            }
            tartacznicy.add(tartacznik);
            wszyscyTartacznicy.add(tartacznik);
        }
    }
    public void dodajZadanie(Zadanie noweZadanie) {
        if(!zadania.contains(noweZadanie)) {
            zadania.add(noweZadanie);
            noweZadanie.addGrupaTartaczników(this);
        }
    }

    public String getSpecjalizacja() {
        return specjalizacja;
    }

    @Override
    public String toString() {
        StringBuilder info = new StringBuilder("GrupaTartaczników: " +
                "specjalizacja='" + specjalizacja + '\'');
        for (Tartacznik t:tartacznicy) {
            info.append("       ");
            info.append(t);
        }
        return info.toString();
    }
}
