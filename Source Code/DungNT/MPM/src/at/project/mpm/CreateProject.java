package at.project.mpm;

import android.os.Bundle;
import android.app.Activity;
import android.content.Intent;
import android.view.Menu;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.view.View.OnClickListener;

public class CreateProject extends Activity {
	private EditText txtproject;

	@Override
	protected void onCreate(Bundle savedInstanceState) {
		super.onCreate(savedInstanceState);
		setContentView(R.layout.activity_create_project);
		Button cancel = (Button) findViewById(R.id.btn_cancel);
		cancel.setOnClickListener(new OnClickListener() {

			@Override
			public void onClick(View v) {
				// TODO Auto-generated method stub
				finish();
			}
		});
		
		Button save = (Button) findViewById(R.id.btn_save);
		save.setOnClickListener(new OnClickListener() {
			@Override
			public void onClick(View v) {
				// TODO Auto-generated method stub
				sendToMain(Home.REQUEST_CODE_SAVE);
			}
		});
	}
	
	
	public void sendToMain(int resultcode)
	{	
		txtproject = (EditText) findViewById(R.id.projectname);
		Intent intent=getIntent();
		String value=txtproject.getText().toString();
		intent.putExtra("data", value);
		setResult(resultcode, intent);
		finish();
	}
	
	@Override
	public boolean onCreateOptionsMenu(Menu menu) {
		// Inflate the menu; this adds items to the action bar if it is present.
		getMenuInflater().inflate(R.menu.create_project, menu);
		return true;
	}

}
