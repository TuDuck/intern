package com.example.apptruyen_sqlite;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.os.Bundle;
import android.util.Log;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.Toast;

import com.example.apptruyen_sqlite.database.databasedoctruyen;

import com.example.apptruyen_sqlite.model.TaiKhoan;

public class ManDangKy extends AppCompatActivity {
    EditText editDKtaikhoan, editDKmatkhau, editDKemail;
    Button btnDangky, btnBack;
    databasedoctruyen databasedoctruyen;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_man_dang_ky);

        AnhXa();
        databasedoctruyen = new databasedoctruyen(this);
        btnDangky.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                String taikhoan = editDKtaikhoan.getText().toString();
                String matkhau = editDKmatkhau.getText().toString();
                String email = editDKemail.getText().toString();

                TaiKhoan taikhoan1 = CreateTaikhoan();
                // check rong
                if(taikhoan.equals("")||matkhau.equals("")||email.equals("") ){
                    Log.e("thông báo ", "chưa nhập đủ thông tin");
                }
                else {
                    databasedoctruyen.AddTaiKhoan(taikhoan1);
                    Toast.makeText(ManDangKy.this,"success",Toast.LENGTH_LONG).show();
                }
            }
        });
        btnBack.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                Intent intent = new Intent(ManDangKy.this,ManDangnhap.class);
                startActivity(intent);
            }
        });
    }

    private TaiKhoan CreateTaikhoan(){
        String taikhoan = editDKtaikhoan.getText().toString();
        String matkhau = editDKmatkhau.getText().toString();
        String email = editDKemail.getText().toString();
        int phanquyen = 1;

        TaiKhoan tk = new TaiKhoan(taikhoan,matkhau,email,phanquyen);

        return tk;
    }

    private void AnhXa() {
        editDKtaikhoan = findViewById(R.id.dktaikhoan);
        editDKmatkhau = findViewById(R.id.dkmatkhau);
        editDKemail = findViewById(R.id.dKemail);
        btnDangky = findViewById(R.id.dkdangky);
        btnBack = findViewById(R.id.backDN);


    }
}