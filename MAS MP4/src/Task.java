import utils.ObjectPlus4;

public class Task extends ObjectPlus4 {
    private String TaskId;
    public static final String isPrepared = "is prepared by";
    public static final String isDone = "is done by";

    public Task(String taskId) {
        TaskId = taskId;
    }

    public String getTaskId() {
        return TaskId;
    }

    public void setTaskId(String taskId) {
        TaskId = taskId;
    }

    @Override
    public String toString() {
        return "Task{" +
                "TaskId='" + TaskId + '\'' +
                '}';
    }
}
