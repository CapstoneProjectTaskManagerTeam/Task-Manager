package fsg.mpmclientside.controllers;

import fsg.mpmclientside.R;
import fsg.mpmclientside.R.layout;
import fsg.mpmclientside.R.menu;
import android.os.Bundle;
import android.app.Activity;
import android.view.Menu;

public class TasksOnProjectActivity extends Activity {

	@Override
	protected void onCreate(Bundle savedInstanceState) {
		super.onCreate(savedInstanceState);
		setContentView(R.layout.activity_tasks_on_project);
	}

	@Override
	public boolean onCreateOptionsMenu(Menu menu) {
		// Inflate the menu; this adds items to the action bar if it is present.
		getMenuInflater().inflate(R.menu.tasks_on_project, menu);
		return true;
	}

}
