package at.project.mpm;

import java.util.Calendar;
import android.os.Bundle;
import android.app.Activity;
import android.app.DatePickerDialog;
import android.app.Dialog;
import android.view.Menu;
import android.view.View;
import android.view.View.OnClickListener;
import android.widget.Button;
import android.widget.DatePicker;
import android.widget.TextView;

public class AddTask extends Activity {

	private TextView txtview1;
	private TextView txtview2;
	private Button btnset1;
	private Button btnset2;
	private int year1,year2;
	private int month1,month2;
	private int day1,day2;
	static final int DATE_DIALOG_ID1 = 999;
	static final int DATE_DIALOG_ID2 = 111;

	@Override
	protected void onCreate(Bundle savedInstanceState) {
		super.onCreate(savedInstanceState);
		setContentView(R.layout.activity_add_task);
		setCurrentDateOnView();
		addListenerOnButton1();
		addListenerOnButton2();
	}

	// Display curren date
	public void setCurrentDateOnView() {

		txtview1 = (TextView) findViewById(R.id.setdate);
		txtview2 = (TextView) findViewById(R.id.dueDate);
		// dpResult = (DatePicker) findViewById(R.id.dpResult);

		final Calendar c = Calendar.getInstance();
		year1 = c.get(Calendar.YEAR);
		month1 = c.get(Calendar.MONTH);
		day1 = c.get(Calendar.DAY_OF_MONTH);
		
		year2 = c.get(Calendar.YEAR);
		month2 = c.get(Calendar.MONTH);
		day2 = c.get(Calendar.DAY_OF_MONTH);

		// set current date into textview
		txtview1.setText(new StringBuilder()
				// Month is 0 based, just add 1
				.append(month1 + 1).append("-").append(day1).append("-")
				.append(year1).append(" "));

		txtview2.setText(new StringBuilder()
				// Month is 0 based, just add 1
				.append(month2 + 1).append("-").append(day2).append("-")
				.append(year2).append(" "));

	}

	public void addListenerOnButton1() {

		btnset1 = (Button) findViewById(R.id.btn_setDate);

		btnset1.setOnClickListener(new OnClickListener() {

			public void onClick(View v) {

				showDialog(DATE_DIALOG_ID1);

			}
		});
	}

	public void addListenerOnButton2() {

		btnset2 = (Button) findViewById(R.id.btn_dueDate);

		btnset2.setOnClickListener(new OnClickListener() {

			public void onClick(View v) {

				showDialog(DATE_DIALOG_ID2);

			}
		});
	}

	@Override
	protected Dialog onCreateDialog(int id) {
		switch (id) {
		case DATE_DIALOG_ID1:
			// set date picker as current date
			return new DatePickerDialog(this, datePickerListener1, year1, month1,
					day1);
		case DATE_DIALOG_ID2:
			return new DatePickerDialog(this, datePickerListener2, year2, month2,
					day2);
		}
		return null;
	}

	private DatePickerDialog.OnDateSetListener datePickerListener1 = new DatePickerDialog.OnDateSetListener() {

		// when dialog box is closed, below method will be called.
		public void onDateSet(DatePicker view, int selectedYear,
				int selectedMonth, int selectedDay) {
			year1 = selectedYear;
			month1 = selectedMonth;
			day1 = selectedDay;

			// set selected date into textview
			txtview1.setText(new StringBuilder().append(month1 + 1)
					.append("-").append(day1).append("-").append(year1)
					.append(" "));

			// set selected date into datepicker also
			// dpResult.init(year, month, day, null);

		}
	};
	private DatePickerDialog.OnDateSetListener datePickerListener2 = new DatePickerDialog.OnDateSetListener() {

		// when dialog box is closed, below method will be called.
		public void onDateSet(DatePicker view, int selectedYear,
				int selectedMonth, int selectedDay) {
			year2 = selectedYear;
			month2 = selectedMonth;
			day2 = selectedDay;

			// set selected date into textview
			txtview2.setText(new StringBuilder().append(month2 + 1)
					.append("-").append(day2).append("-").append(year2)
					.append(" "));

			// set selected date into datepicker also
			// dpResult.init(year, month, day, null);

		}
	};

	public boolean onCreateOptionsMenu(Menu menu) {
		// Inflate the menu; this adds items to the action bar if it is present.
		getMenuInflater().inflate(R.menu.add_task, menu);
		return true;
	}

}
