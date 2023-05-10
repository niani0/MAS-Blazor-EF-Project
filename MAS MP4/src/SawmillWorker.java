import static java.lang.String.format;

public class SawmillWorker {

    public final static float minimumSalary = 2000;
    private int salary;

    public SawmillWorker(int salary) throws Exception {
        setSalary(salary);
    }

    public int getSalary() {
        return salary;
    }

    public void setSalary(int salary) throws Exception {
        if(salary < this.salary) {
            throw new Exception("The salary cannot be decreased!");
        }
        if(salary < minimumSalary) {
            throw new Exception(format("The new salary (%s) has to be at least %s", salary, minimumSalary));
        }
        this.salary = salary;
    }
}
