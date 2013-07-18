package fsg.mpmclientside.models;

import java.util.Observable;
import java.io.Serializable;

public class mUser extends Observable implements Serializable{

	// Properties
	private int userId;
	public int getUserID(){
		return this.userId;
	}
	public void setUserID(int userId){
		this.userId = userId;
		this.setChanged();
		this.notifyObservers();
	}
	
	private String name;
	public String getName(){
		return this.name;
	}
	public void setName(String name){
		this.name = name;
		this.setChanged();
		this.notifyObservers();
	}
	
	private int groupId;
	public int getGroupID(){
		return this.groupId;
	}
	public void setGroupID(int groupId){
		this.groupId = groupId;
		this.setChanged();
		this.notifyObservers();
	}
	
	private String email;
	public String getEmail(){
		return this.email;
	}
	public void setEmail(String email){
		this.email = email;
		this.setChanged();
		this.notifyObservers();
	}
	
	private String password;
	public String getPassword(){
		return this.password;
	}
	public void setPassword(String password){
		this.password = password;
		this.setChanged();
		this.notifyObservers();
	}
	
	private String avatar;
	public String getAvatar(){
		return this.avatar;
	}
	public void setAvatar(String avatar){
		this.avatar = avatar;
		this.setChanged();
		this.notifyObservers();
	}
	
	private String userTypeId;
	public String getUserTypeID(){
		return this.userTypeId;
	}
	public void setUserTypeID(String userTypeId){
		this.userTypeId = userTypeId;
		this.setChanged();
		this.notifyObservers();
	}
	private String genderId;
	public String getGenderID(){
		return this.genderId;
	}
	public void setGenderID(String genderId){
		this.genderId = genderId;
		this.setChanged();
		this.notifyObservers();
	}
	private String authenticationTypeId;
	public String getAuthenticationTypeID(){
		return this.authenticationTypeId;
	}
	public void setAuthenticationTypeID(String authenticationTypeId){
		this.authenticationTypeId = authenticationTypeId;
		this.setChanged();
		this.notifyObservers();
	}
	// Constructor
	public mUser(){
	}
}
