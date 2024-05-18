package com.example.apptruyen_sqlite;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.os.Bundle;
import android.text.method.ScrollingMovementMethod;
import android.widget.TextView;

public class ManNoiDung extends AppCompatActivity {
    TextView txtTentruyen ,txtNoidung;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_man_noi_dung);
        txtTentruyen = findViewById(R.id.TenTruyen);
        txtNoidung = findViewById(R.id.noidung);

        Intent intent = getIntent();
        String tentruyen = intent.getStringExtra("tentruyen");
        String noidung = intent.getStringExtra("noidung");

        txtTentruyen.setText(tentruyen);
        txtNoidung.setText(noidung);
        // cuon chuot
        txtNoidung.setMovementMethod( new ScrollingMovementMethod());
    }
}