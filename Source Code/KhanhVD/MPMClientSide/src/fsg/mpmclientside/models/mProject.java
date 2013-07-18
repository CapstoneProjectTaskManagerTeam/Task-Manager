package fsg.mpmclientside.models;

import java.io.Serializable;
import java.util.Date;
import java.util.Observable;

public class mProject extends Observable implements Serializable{

	// Properties
	private int projectId;
	public int getProjectID(){
		return this.projectId;
	}
	public void setProjectID(int projectId){
		this.projectId = projectId;
		this.setChanged();
		this.notifyObservers();
	}
	
	private String projectName;
	public String getProjectName(){
		return this.projectName;
	}
	public void setProjectName(String projectName){
		this.projectName = projectName;
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
	
	private int ownerUser;
	public int getOwnerUser(){
		return this.ownerUser;
	}
	public void setOwnerUser(int ownerUser){
		this.ownerUser = ownerUser;
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
	public mProject(){
		
	}
}
