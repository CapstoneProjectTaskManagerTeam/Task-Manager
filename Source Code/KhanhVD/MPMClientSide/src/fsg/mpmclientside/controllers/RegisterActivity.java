package fsg.mpmclientside.controllers;

import java.io.InputStream;
import java.io.InputStreamReader;

import org.apache.http.HttpEntity;
import org.apache.http.HttpResponse;
import org.apache.http.client.methods.HttpGet;
import org.apache.http.client.methods.HttpPost;
import org.apache.http.entity.StringEntity;
import org.apache.http.impl.client.DefaultHttpClient;
import org.json.JSONArray;
import org.json.JSONStringer;

import fsg.mpmclientside.R;
import fsg.mpmclientside.R.layout;
import fsg.mpmclientside.R.menu;
import android.os.Bundle;
import android.app.Activity;
import android.text.Editable;
import android.util.Log;
import android.view.Menu;
import android.view.View;
import android.widget.ArrayAdapter;
import android.widget.Button;
import android.widget.EditText;

public class RegisterActivity extends Activity {

	//Views
	EditText editName, editEmail, editPassword;
	Button btnSummit;
	//Properties
	final static String SERVICE_URI="";
	final static String TAG="";
	
	
	@Override
	protected void onCreate(Bundle savedInstanceState) {
		super.onCreate(savedInstanceState);
		setContentView(R.layout.activity_register);
		
		editName = (EditText) findViewById(R.id.editName);
		editEmail = (EditText) findViewById(R.id.editEmail);
		editPassword = (EditText) findViewById(R.id.editPassword);
		btnSummit = (Button) findViewById(R.id.btnSubmit);
	}
	
	public void onSummitClick(View v){
		try{
			Editable name = editName.getText();
			Editable email = editEmail.getText();
			Editable password= editPassword.getText();
			
			boolean isValid = true;
			
			if(isValid){
				
				HttpPost request = new HttpPost(SERVICE_URI + "SignUp");
				request.setHeader("Accept","application/json");
				request.setHeader("Content-type","application/json");
				
				JSONStringer user = new JSONStringer()
					.object()
						.key("user")
							.object()
								.key("name").value(name)
								.key("email").value(email)
								.key("password").value(password)
							.endObject()
						.endObject();
				StringEntity entity = new StringEntity(user.toString());
				request.setEntity(entity);
				
				// Send request to WCF service
				DefaultHttpClient httpClient = new DefaultHttpClient();
				HttpResponse response = httpClient.execute(request);
				
				Log.d("WebInvoke", "Saving" + response.getStatusLine().getStatusCode());
				
			}
		}catch(Exception i){
			i.printStackTrace();
		}
	}

	@Override
	public boolean onCreateOptionsMenu(Menu menu) {
		// Inflate the menu; this adds items to the action bar if it is present.
		getMenuInflater().inflate(R.menu.register, menu);
		return true;
	}

}
