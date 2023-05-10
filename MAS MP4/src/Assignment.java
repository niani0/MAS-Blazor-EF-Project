public class Assignment {
    private int number;
    private String status;

    public Assignment(int number, String status) throws Exception {
        this.number = number;
        setStatus(status);
    }

    private void setStatus(String status) throws Exception{
        if (status.equals(AssignmentStatus.Accepted.toString()) || status.equals(AssignmentStatus.Canceled.toString()) ||
                status.equals(AssignmentStatus.Implemented.toString()))
            this.status = status;
        else
            throw new Exception("Wrong status form");
    }
    public void changeStatus(String newStatus) throws Exception
    {
        if (newStatus.equals(AssignmentStatus.Canceled.toString()) || newStatus.equals(AssignmentStatus.Implemented.toString()) ||
                newStatus.equals(AssignmentStatus.Accepted.toString()))
        {
            if (!this.status.equals(newStatus))
            {
                this.status = newStatus;
            }
            else
                throw new Exception("Status is the same");
        }
        else
            throw new Exception("Wrong status form");

    }

    @Override
    public String toString() {
        return "Assignment{" +
                "number=" + number +
                ", status='" + status + '\'' +
                '}';
    }
}
