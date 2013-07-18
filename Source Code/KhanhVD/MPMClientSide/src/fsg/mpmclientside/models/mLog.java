package fsg.mpmclientside.models;

import java.io.Serializable;
import java.util.Date;
import java.util.Observable;

public class mLog extends Observable implements Serializable {

	// Properties
	private int logId;
	public int getLog(){
		return this.logId;
	}
	public void setLogID(int logId){
		this.logId = logId;
		this.setChanged();
		this.notifyObservers();
	}
	
	private Date time;
	public Date getTime(){
		return this.time;
	}
	public void setTime(Date time){
		this.time = time;
		this.setChanged();
		this.notifyObservers();
	}
	
	private String tag;
	public String getTAG(){
		return this.tag;
	}
	public void setTAG(String tag){
		this.tag = tag;
		this.setChanged();
		this.notifyObservers();
	}
	
	private String actor;
	public String getActor(){
		return this.actor;
	}
	public void setActor(String actor){
		this.actor = actor;
		this.setChanged();
		this.notifyObservers();
	}
	
	private String method;
	public String getMethod(){
		return this.method;
	}
	public void setMethod(String method){
		this.method = method;
		this.setChanged();
		this.notifyObservers();
	}
	
	private String type;
	public String getType(){
		return this.type;
	}
	public void setType(String type){
		this.type = type;
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
	// Constructor
	public mLog(){
		
	}
}
