public class WorkGroup {
    private String specialization;

    public String getSpecialization() {
        return specialization;
    }

    public void setSpecialization(String specialization) {
        this.specialization = specialization;
    }

    public WorkGroup(String specialization) {
        this.specialization = specialization;
    }

    @Override
    public String toString() {
        return "WorkGroup{" +
                "specialization='" + specialization + '\'' +
                '}';
    }
}
