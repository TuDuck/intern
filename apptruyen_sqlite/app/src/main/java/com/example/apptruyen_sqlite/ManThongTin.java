package com.example.apptruyen_sqlite;

import androidx.appcompat.app.AppCompatActivity;

import android.os.Bundle;
import android.widget.TextView;

public class ManThongTin extends AppCompatActivity {
    TextView txtthongtin;


    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_man_thong_tin);
        txtthongtin =findViewById(R.id.textviewthongtin);

        String thongtin = "Ứng dụng được phát hành bởi 'tuduck' \n"+"uy tin "+"đẹp trai";
        txtthongtin.setText(thongtin);
    }
}