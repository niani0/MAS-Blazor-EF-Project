import java.time.LocalDate;

public class Main {
    public static void main(String[] args) throws Exception {
        attribute();
        unique();
        System.out.println("subset");
        subset();
        System.out.println("ordered");
        ordered();
        System.out.println("bag");
        bag();
        System.out.println("xor");
        xor();
        System.out.println("custom");
        custom();
    }

    private static void custom() throws Exception {
        Assignment a = new Assignment(1,"Accepted");
        System.out.println(a);
//        a.changeStatus("bla");
        a.changeStatus("Implemented");
        System.out.println(a);
        System.out.println();
    }

    private static void xor() throws Exception {
        Company c = new Company("12");
        Owner o = new Owner("costam@wp.pl");
        CompanyWorker cw = new CompanyWorker("Mateusz");
        o.addXorRole(Owner.isOwning);
//        o.addXorRole(Owner.has);
        o.addLinkXor(Owner.isOwning,Company.isOwnedBy,c);
        o.addLinkXor(Owner.has,CompanyWorker.isWorkingFor,cw);
        o.addLinkXor(Owner.has,CompanyWorker.isWorkingFor,cw);
        System.out.println(o.rolesXOR);
        o.showLinks(Owner.isOwning,System.out);
//        o.showLinks(Owner.has,System.out);
        System.out.println();
    }

    private static void bag() {
        Supervisor supervisor1 = new Supervisor("Jan", 1200);
        Order order1 = new Order("Id1");

        SupervisorOrder supervisorOrder1 = new SupervisorOrder(LocalDate.of(2001,11,2),order1,supervisor1);
        SupervisorOrder supervisorOrder2 = new SupervisorOrder(LocalDate.now(),order1,supervisor1);

        System.out.println(supervisorOrder1);
        System.out.println(supervisorOrder2);
        System.out.println();
    }

    private static void ordered() throws Exception {
        Manager manager = new Manager("606");
        manager.addWorkGroup(new WorkGroup("BBB"));
        manager.addWorkGroup(new WorkGroup("AAA"));
        manager.addWorkGroup(new WorkGroup("AAA"));
        System.out.println(manager.getWorkGroupTreeSet());
        System.out.println();
    }

    private static void subset() throws Exception {
        Worker worker = new Worker("Eniu", LocalDate.now());
        Task task = new Task("id1");

        worker.addLink(Worker.prepares, Task.isPrepared, task);
        worker.addLink_subset(Worker.does, Task.isDone, Worker.prepares, task);

        worker.showLinks(Worker.prepares, System.out);
        worker.showLinks(Worker.does, System.out);
        System.out.println();
    }

    private static void unique() throws Exception {
        Person person = new Person("Wlodzimierz", LocalDate.now(), "1");
        Person person2 = new Person("Marcin", LocalDate.now(), "12");

    }

    private static void attribute() throws Exception {
        SawmillWorker sawmillWorker = new SawmillWorker(2000);
        sawmillWorker.setSalary(2100);
    }


}