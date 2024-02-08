// Inheritance example
public class WorkItem
{
    // Static field currentID stores the job iD of the last WorkItem that was created
    private static int currentID;
    
    //Properties
    public int ID { get;  set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public TimeSpan jobLength { get; set; }

    public WorkItem() {
        ID = 0;
        Title = "Default title";
        Description = "Default description";
        jobLength = new TimeSpan();
    }

    public WorkItem(string title, string description, TimeSpan jobLength) {
        this.ID = GetNextID();
        this.Title = title;
        this.Description = description;
        this.jobLength = jobLength;
    }

    static WorkItem() => currentID = 0;

    protected int GetNextID() => ++currentID;

    public void Update(string title, TimeSpan joblen) {
        this.Title = title;
        this.jobLength = joblen;
    }
    
    public override string ToString() => $"{this.ID} - {this.Title}";
}

public class ChangeRequest : WorkItem
{
    protected int originalItemID { get; set; }

    public ChangeRequest() {}

    public ChangeRequest(string title, string desc, TimeSpan jobLen, int originalID) {
        this.ID = GetNextID();
        this.Title = title;
        this.Description = desc;
        this.jobLength = jobLen;
        this.originalItemID = originalID;
    }
}
