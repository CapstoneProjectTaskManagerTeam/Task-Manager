package at.project.mpm;

import java.util.ArrayList;
import android.os.Bundle;
import android.app.Activity;
import android.content.Intent;
import android.view.Menu;
import android.view.View;
import android.widget.ArrayAdapter;
import android.widget.Button;
import android.widget.ImageButton;
import android.widget.ListView;
import android.view.View.OnClickListener;

public class Home extends Activity {
	private ListView lvData;
	public static final int REQUEST_CODE_INPUT=1;
	public static final int REQUEST_CODE_SAVE=2;
	ArrayList<String>arrData=new ArrayList<String>();
	ArrayAdapter<String>adapter=null;
	
	@Override
	protected void onCreate(Bundle savedInstanceState) {
		super.onCreate(savedInstanceState);
		setContentView(R.layout.activity_home);
		
		//Test add task
		Button btnaddtask=(Button) findViewById(R.id.test_addTask);
		btnaddtask.setOnClickListener(new OnClickListener() {
			
			@Override
			public void onClick(View v) {
				// TODO Auto-generated method stub
				Intent testIntent=new Intent(Home.this,AddTask.class);
				startActivity(testIntent);
			}
		});
		
		ImageButton imguser=(ImageButton) findViewById(R.id.btn_user);
		imguser.setOnClickListener(new OnClickListener() {
			
			@Override
			public void onClick(View v) {
				// TODO Auto-generated method stub
				Intent myIntent= new Intent(Home.this,User.class);
				startActivity(myIntent);
			}
		});
		ImageButton imgcreate=(ImageButton) findViewById(R.id.btn_create);
		imgcreate.setOnClickListener(new OnClickListener() {
			
			@Override
			public void onClick(View v) {
				// TODO Auto-generated method stub
				Intent myIntent= new Intent(Home.this,CreateProject.class);
				startActivityForResult(myIntent,REQUEST_CODE_INPUT);
			}
		});
		lvData=(ListView) findViewById(R.id.listView1);
		adapter=new ArrayAdapter<String>
			(this, 
			android.R.layout.simple_list_item_1, 
			arrData);
		lvData.setAdapter(adapter);
	}
	
	
	@Override
	protected void onActivityResult(int requestCode, int resultCode, Intent data) {
		// TODO Auto-generated method stub
		super.onActivityResult(requestCode, resultCode, data);

		if(requestCode==REQUEST_CODE_INPUT)
		{
			if(resultCode==REQUEST_CODE_SAVE){
				String v1= data.getStringExtra("data");
				arrData.add(v1);
				adapter.notifyDataSetChanged();
			}
		}
	}
	
	public boolean onCreateOptionsMenu(Menu menu) {
		// Inflate the menu; this adds items to the action bar if it is present.
		getMenuInflater().inflate(R.menu.home, menu);
		return true;
	}

}
