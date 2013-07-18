package fsg.mpmclientside.models;

import java.io.Serializable;
import java.util.Date;
import java.util.Observable;

public class mTask extends Observable implements Serializable {
	// Properties
	private int taskId;
	public int getTaskID(){
		return this.taskId;
	}
	public void setTaskID(int taskId){
		this.taskId = taskId;
		this.setChanged();
		this.notifyObservers();
	}
	
	private String taskName;
	public String getTaskName(){
		return this.taskName;
	}
	public void setTaskName(String taskName){
		this.taskName = taskName;
		this.setChanged();
		this.notifyObservers();
	}
	
	private String description;
	public String getDescription(){
		return this.description;
	}
	public void setDescription(String description){
		this.description = description;
		this.setChanged();
		this.notifyObservers();
	}
	
	private int stateId;
	public int getStateID(){
		return this.stateId;
	}
	public void setStateID(int stateId){
		this.stateId = stateId;
		this.setChanged();
		this.notifyObservers();
	}
	
	private int projectId;
	public int getProjectID(){
		return this.projectId;
	}
	public void setProjectID(int projectId){
		this.projectId = projectId;
		this.setChanged();
		this.notifyObservers();
	}
	
	private int comments;
	public int getComments(){
		return this.comments;
	}
	public void setComments(int comments){
		this.comments = comments;
		this.setChanged();
		this.notifyObservers();
	}
	
	private String status;
	public String getStatus(){
		return this.status;
	}
	public void setStatus(String status){
		this.status = status;
		this.setChanged();
		this.notifyObservers();
	}
	
	private Date startDate;
	public Date getStartDate(){
		return this.startDate;
	}
	public void setStartDate(Date startDate){
		this.startDate = startDate;
		this.setChanged();
		this.notifyObservers();
	}
	
	private Date dueDate;
	public Date getDueDate(){
		return this.dueDate;
	}
	public void setDueDate(Date dueDate){
		this.dueDate = dueDate;
		this.setChanged();
		this.notifyObservers();
	}
		
	// Constructor
	public mTask(){
		
	}
}
