package fsg.mpmclientside.models;

import java.io.Serializable;
import java.util.Observable;

public class mMessage extends Observable implements Serializable {

	// Properties
	private int offlineMessageId;
	public int getOfflineMessageID(){
		return this.offlineMessageId;
	}
	public void setOfflineMessageID(int offlineMessageId){
		this.offlineMessageId = offlineMessageId;
		this.setChanged();
		this.notifyObservers();
	}
	
	public int sender;
	public int getSender(){
		return this.sender;
	}
	public void setSender(int sender){
		this.sender = sender;
		this.setChanged();
		this.notifyObservers();
	}
	
	public int receiver;
	public int getReceiver(){
		return this.receiver;
	}
	public void setReceiver(int receiver){
		this.receiver = receiver;
		this.setChanged();
		this.notifyObservers();
	}
	// Constructor
	public mMessage(){
		
	}
}
