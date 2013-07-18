package fsg.mpmclientside.models;

import java.io.Serializable;
import java.util.Observable;

public class mComment extends Observable implements Serializable {

	// Properties
	private int commentId;
	public int getCommentId(){
		return this.commentId;
	}
	public void setCommentID(int commentId){
		this.commentId = commentId;
		this.setChanged();
		this.notifyObservers();
	}
	
	private String content;
	public String getContent(){
		return this.content;
	}
	public void setContent(String content){
		this.content = content;
		this.setChanged();
		this.notifyObservers();
	}
	
	private int userId;
	public int getuserId(){
		return this.userId;
	}
	public void setUserID(int userId){
		this.userId = userId;
		this.setChanged();
		this.notifyObservers();
	}
	
	private int taskId;
	public int getTaskId(){
		return this.taskId;
	}
	public void setTaskID(int taskId){
		this.taskId = taskId;
		this.setChanged();
		this.notifyObservers();
	}
	
	// Constructor 
	public mComment(){
		
	}
}
