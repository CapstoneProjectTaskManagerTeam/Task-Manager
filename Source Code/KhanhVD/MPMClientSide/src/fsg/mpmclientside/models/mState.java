package fsg.mpmclientside.models;

import java.io.Serializable;
import java.util.Date;
import java.util.Observable;

public class mState extends Observable implements Serializable {
	// Properties
	private int stateId;
	public int getStateId(){
		return this.stateId;
	}
	public void setStateID(int stateId){
		this.stateId = stateId;
		this.setChanged();
		this.notifyObservers();
	}
	
	private String stateName;
	public String getStateName(){
		return this.stateName;
	}
	public void setStateName(String stateName){
		this.stateName = stateName;
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
	
	private int projectId;
	public int getProjectId(){
		return this.projectId;
	}
	public void setProjectID(int projectId){
		this.projectId = projectId;
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
}
