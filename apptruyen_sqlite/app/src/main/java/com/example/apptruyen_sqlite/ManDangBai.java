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
import com.example.apptruyen_sqlite.model.Truyen;

public class ManDangBai extends AppCompatActivity {

        EditText edittentruyen , editnoidung,editanh;
        Button btnDangbai;
        databasedoctruyen databasedoctruyen;


    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_man_dang_bai);

        editanh = findViewById(R.id.dbAnh);
        edittentruyen = findViewById(R.id.dbTenTruyen);
        editnoidung = findViewById(R.id.dbNoiDung);
        btnDangbai = findViewById(R.id.dbdangbai);

        databasedoctruyen = new databasedoctruyen(this);

        /// dang bai
        btnDangbai.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                String tentruyen = edittentruyen.getText().toString();
                String noidung = editnoidung.getText().toString();
                String img = editanh.getText().toString();

                Truyen truyen = CreateTruyen();
                if(tentruyen.equals("")||noidung.equals("")||img.equals("")){
                    Toast.makeText(ManDangBai.this,"yeu cau nhap du thong tin",Toast.LENGTH_SHORT).show();
                    Log.e("error","nhap day du thong tin deeee");
                }
                else {
                    databasedoctruyen.AddTruyen(truyen);

                    Intent intent = new Intent(ManDangBai.this,ManAdmin.class);
                    finish();
                    startActivity(intent);
                }
            }
        });

    }
    private Truyen CreateTruyen(){
        String tentruyen = edittentruyen.getText().toString();
        String noidung = editnoidung.getText().toString();
        String img = editanh.getText().toString();

        Intent intent = getIntent();

        int id = intent.getIntExtra("id",0);
        Truyen truyen = new Truyen(tentruyen,noidung,img,id);
        return truyen;
    }
}