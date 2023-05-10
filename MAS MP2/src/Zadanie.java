import java.time.LocalDate;
import java.util.ArrayList;
import java.util.List;
import java.util.Map;
import java.util.TreeMap;

public class Zadanie {
    private String stan;
    private LocalDate dataRozpoczęcia;
    private LocalDate dataZakończenia;

    private List<Materiał> materiały = new ArrayList<>();
    private List<RaportZZadania> raporty = new ArrayList<>();
    private Map<String, GrupaTartaczników> grupaTartaczników = new TreeMap<>();
    public Zadanie(String stan, LocalDate dataRozpoczęcia, LocalDate dataZakończenia) {
        this.stan = stan;
        this.dataRozpoczęcia = dataRozpoczęcia;
        this.dataZakończenia = dataZakończenia;
    }
    public void dodajMateriał(Materiał nowyMateriał) {
        if(!materiały.contains(nowyMateriał)) {
            materiały.add(nowyMateriał);
            nowyMateriał.dodajZadanie(this);
        }
    }
    public void dodajRaport(RaportZZadania nowyRaport){
        if(!raporty.contains(nowyRaport)) {
            raporty.add(nowyRaport);
            nowyRaport.setZadanie(this);
        }
    }
    public void usunRaport(RaportZZadania raport){
        raporty.remove(raport);
        raport.removeZadanie();
    }

    public String getStan() {
        return stan;
    }

    public LocalDate getDataRozpoczęcia() {
        return dataRozpoczęcia;
    }

    public LocalDate getDataZakończenia() {
        return dataZakończenia;
    }

    public void addGrupaTartaczników(GrupaTartaczników nowaGrupaTartaczników) {
        if(!grupaTartaczników.containsKey(nowaGrupaTartaczników.getSpecjalizacja())) {
            grupaTartaczników.put(nowaGrupaTartaczników.getSpecjalizacja(), nowaGrupaTartaczników);
            nowaGrupaTartaczników.dodajZadanie(this);
        }
    }
    public GrupaTartaczników znajdzGrupeTartacznikow(String specjalizacja) throws Exception {
// Check if we have the info
        if(!grupaTartaczników.containsKey(specjalizacja)) {
            throw new Exception("Nie można znaleźć grupy ze specjalizacją: " + specjalizacja);
        }
        return grupaTartaczników.get(specjalizacja);
    }

    @Override
    public String toString() {
        StringBuilder info = new StringBuilder("Zadanie: " +
                "stan='" + stan + '\'' +
                ", dataRozpoczęcia=" + dataRozpoczęcia +
                ", dataZakończenia=" + dataZakończenia );
        for (Materiał m:materiały) {
            info.append("    ").append(m.getNazwa());
        }
        for (RaportZZadania r: raporty) {
            info.append("    ").append(r.getNazwa());
        }
        if (!grupaTartaczników.isEmpty()) info.append(grupaTartaczników);
        return info.toString();
    }
}
