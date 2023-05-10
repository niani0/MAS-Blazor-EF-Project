import java.util.Random;

public class Kierownik {
    private String numerTelefoniczny;
    private RaportZZadania raport;

    public Kierownik(String numerTelefoniczny) {
        this.numerTelefoniczny = numerTelefoniczny;
    }
    public void setRaport(RaportZZadania nowyraport) {
        if (raport == null) {
            raport = nowyraport;
            raport.setKierownik(this);
        }
    }
    public void removeRaport() {
        if (raport != null) {
            raport.removeKierownik();
            raport = null;
        }
    }

    @Override
    public String toString() {
        return "Kierownik{" +
                "numerTelefoniczny='" + numerTelefoniczny + '\'' +
                ", raport=" + raport.getNazwa() +
                '}';
    }
}
