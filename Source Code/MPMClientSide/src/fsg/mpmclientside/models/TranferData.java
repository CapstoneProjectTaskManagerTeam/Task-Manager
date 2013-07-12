package fsg.mpmclientside.models;

import java.io.InputStream;
import java.io.InputStreamReader;

import org.apache.http.HttpEntity;
import org.apache.http.HttpResponse;
import org.apache.http.client.methods.HttpGet;
import org.apache.http.impl.client.DefaultHttpClient;

public class TranferData {

	public char[] getResponseData(String service_uri, String operation){
		try{
			//Send a request to WCF service.
			String requestString = service_uri + operation;
			HttpGet request = new HttpGet(requestString);
			request.setHeader("Accept","application/json");
			request.setHeader("Content-type","application/json");
			
			DefaultHttpClient httpClient = new DefaultHttpClient();
			HttpResponse response = httpClient.execute(request);
			
			HttpEntity responseEntity = response.getEntity();
			
			//Read response data from buffer.
			char[] buffer = new char[(int)responseEntity.getContentLength()];
			InputStream stream = responseEntity.getContent();
			InputStreamReader reader = new InputStreamReader(stream);
			reader.read(buffer);
			stream.close();
			
			//Return value.
			return buffer;
		}catch(Exception i){
			i.printStackTrace();
			return null;
		}
	}
}
