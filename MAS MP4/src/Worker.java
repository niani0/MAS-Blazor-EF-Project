import utils.ObjectPlus4;

import java.time.LocalDate;

public class Worker extends ObjectPlus4 {
    private String name;
    private LocalDate dateOfJoining;

    public static final String does = "does";
    public static final String prepares = "prepares";

    public Worker(String name, LocalDate dateOfJoining) {
        this.name = name;
        this.dateOfJoining = dateOfJoining;
    }

    public String getName() {
        return name;
    }

    public void setName(String name) {
        this.name = name;
    }

    public LocalDate getDateOfJoining() {
        return dateOfJoining;
    }

    public void setDateOfJoining(LocalDate dateOfJoining) {
        this.dateOfJoining = dateOfJoining;
    }
}
