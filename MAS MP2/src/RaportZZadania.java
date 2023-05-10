import java.time.LocalDate;

public class RaportZZadania {
    private String nazwa;
    private LocalDate dataZrobienia;
    private String opisZadania;
    private Zadanie zadanie;
    private Kierownik kierownik;

    public RaportZZadania(String nazwa, LocalDate dataZrobienia, String opisZadania) {
        this.nazwa = nazwa;
        this.dataZrobienia = dataZrobienia;
        this.opisZadania = opisZadania;
    }

    public void setZadanie(Zadanie noweZadanie) {
        if (zadanie == null) {
            zadanie = noweZadanie;
            zadanie.dodajRaport(this);
        }
    }
    public void removeZadanie() {
        if (zadanie != null) {
            zadanie.usunRaport(this);
            zadanie = null;
        }
    }
    public void setKierownik(Kierownik nowyKierownik) {
        if (kierownik == null) {
            kierownik = nowyKierownik;
            kierownik.setRaport(this);
        }
    }

    public void removeKierownik() {
        if (kierownik != null) {
            kierownik.removeRaport();
            kierownik = null;
        }
    }

    public String getNazwa() {
        return nazwa;
    }

    public LocalDate getDataZrobienia() {
        return dataZrobienia;
    }

    public String getOpisZadania() {
        return opisZadania;
    }

    @Override
    public String toString() {
        return "RaportZZadania: " +
                "nazwa='" + nazwa + '\'' +
                ", dataZrobienia=" + dataZrobienia +
                ", opisZadania='" + opisZadania + '\'' +
                ", zadanie=" + zadanie +
                ", kierownik=" + kierownik;
    }
}
