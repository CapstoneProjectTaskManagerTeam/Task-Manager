package fsg.mpmclientside.models;

import java.io.Serializable;
import java.util.Observable;

public class mNotification extends Observable implements Serializable {

	// Properties
	private int offlineNotificationId;
	public int getOfflineNotificationID(){
		return this.offlineNotificationId;
	}
	public void setOfflineNotificationID(int offlineNotificationId){
		this.offlineNotificationId = offlineNotificationId;
		this.setChanged();
		this.notifyObservers();
	}
	
	public int notificationId;
	public int getNotificationID(){
		return this.notificationId;
	}
	public void setNotificationID(int notificationId){
		this.notificationId = notificationId;
		this.setChanged();
		this.notifyObservers();
	}
	
	public int userId;
	public int getUserID(){
		return this.userId;
	}
	public void setUserID(int userId){
		this.userId = userId;
		this.setChanged();
		this.notifyObservers();
	}
	// Constructor
	public mNotification(){
		
	}
}
