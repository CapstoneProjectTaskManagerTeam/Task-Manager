package fsg.mpmclientside.controllers;


import fsg.mpmclientside.R;
import android.os.Bundle;
import android.app.Activity;
import android.content.Intent;
import android.support.v4.view.ViewPager;
import android.util.Log;
import android.view.View;

public class WellcomeActivity extends Activity {

	final static String TAG = "PresentationLayer.Controllers.WellcomeActivity";
	@Override
	protected void onCreate(Bundle savedInstanceState) {
		super.onCreate(savedInstanceState);
		setContentView(R.layout.activity_wellcome);
		ViewPager viewPager = (ViewPager) findViewById(R.id.view_pager);
	    ImageAdapter adapter = new ImageAdapter(this);
	    viewPager.setAdapter(adapter);
	}
	
	public void OnNewUserClick(View v){
		Intent intent = new Intent(WellcomeActivity.this, RegisterActivity.class);
		startActivity(intent);
		Log.d(TAG, "Click on New User");
	}
	
	public void OnExistingUserClick(View v){
		Intent intent = new Intent(WellcomeActivity.this, LoginActivity.class);
		startActivity(intent);
		Log.d(TAG, "Click on Existing User");
	}

}
