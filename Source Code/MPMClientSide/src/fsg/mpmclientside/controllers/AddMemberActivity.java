package fsg.mpmclientside.controllers;

import fsg.mpmclientside.R;
import fsg.mpmclientside.R.layout;
import fsg.mpmclientside.R.menu;
import android.os.Bundle;
import android.app.Activity;
import android.view.Menu;

public class AddMemberActivity extends Activity {

	@Override
	protected void onCreate(Bundle savedInstanceState) {
		super.onCreate(savedInstanceState);
		setContentView(R.layout.activity_add_member);
	}

	@Override
	public boolean onCreateOptionsMenu(Menu menu) {
		// Inflate the menu; this adds items to the action bar if it is present.
		getMenuInflater().inflate(R.menu.add_member, menu);
		return true;
	}

}
