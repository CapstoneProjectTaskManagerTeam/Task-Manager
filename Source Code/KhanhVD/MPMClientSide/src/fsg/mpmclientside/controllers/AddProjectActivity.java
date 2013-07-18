package fsg.mpmclientside.controllers;

import fsg.mpmclientside.R;
import fsg.mpmclientside.R.layout;
import fsg.mpmclientside.R.menu;
import android.os.Bundle;
import android.app.Activity;
import android.view.Menu;
import android.view.View;
import android.widget.Button;

public class AddProjectActivity extends Activity {

	@Override
	protected void onCreate(Bundle savedInstanceState) {
		super.onCreate(savedInstanceState);
		setContentView(R.layout.activity_add_project);
	}

	public void onCancelClick(View v){
	}
	
	public void onAddClick(View v){
		
	}
	
	@Override
	public boolean onCreateOptionsMenu(Menu menu) {
		// Inflate the menu; this adds items to the action bar if it is present.
		getMenuInflater().inflate(R.menu.add_project, menu);
		return true;
	}

}
