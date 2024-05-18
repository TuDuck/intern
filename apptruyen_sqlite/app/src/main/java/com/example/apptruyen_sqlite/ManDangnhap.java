package com.example.apptruyen_sqlite;

import android.content.Intent;
import android.database.Cursor;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;

import androidx.appcompat.app.AppCompatActivity;

import com.example.apptruyen_sqlite.database.databasedoctruyen;

public class ManDangnhap  extends AppCompatActivity {

    EditText edittaikhoan, editmatkhau;
    Button btnDangnhap,btnDangky;
    databasedoctruyen databasedoctruyen;
    @Override
    protected void onCreate(Bundle savedInstanceState) {

        super.onCreate(savedInstanceState);
        setContentView(R.layout.dang_nhap);
        AnhXa();
        databasedoctruyen = new databasedoctruyen(ManDangnhap.this);
        btnDangky.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                Intent intent = new Intent(ManDangnhap.this,ManDangKy.class);
                startActivity(intent);
            }
        });
        btnDangnhap.setOnClickListener(new View.OnClickListener() {
        @Override
        public void onClick(View v) {
            String tentaikhoan = edittaikhoan.getText().toString();
            String matkhau = editmatkhau.getText().toString();

            Cursor cursor = databasedoctruyen.getData();

            while (cursor.moveToNext()){
                String datatentaikhoan = cursor.getString(1);
                String datamatkhau= cursor.getString(2);
                if(datatentaikhoan.equals(tentaikhoan)&& datamatkhau.equals(matkhau)){
                    int phanquyen = cursor.getInt(4);
                    int idd = cursor.getInt(0);
                    String email = cursor.getString(3);
                    String tentk = cursor.getString(1);

                    Intent intent = new Intent(ManDangnhap.this,MainActivity.class);

                    intent.putExtra("phanq",phanquyen);
                    intent.putExtra("idd",idd);
                    intent.putExtra("email",email);
                    intent.putExtra("tentaikhoan",tentk);
                    startActivity(intent);
                }
            }
            // con tro ve dau
            cursor.moveToFirst();
            // dong
            cursor.close();
        }
    });
    /// run...
    }

    private void AnhXa() {
        editmatkhau = findViewById(R.id.editmatkhau);
        edittaikhoan = findViewById(R.id.edittaikhoan);
        btnDangky = findViewById(R.id.dangky);
        btnDangnhap = findViewById(R.id.dangnhap);

    }
}

