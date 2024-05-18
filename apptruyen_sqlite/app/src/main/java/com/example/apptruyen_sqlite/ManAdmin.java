package com.example.apptruyen_sqlite;

import androidx.appcompat.app.AppCompatActivity;

import android.app.Dialog;
import android.content.Intent;
import android.database.Cursor;
import android.os.Bundle;
import android.view.View;
import android.widget.AdapterView;
import android.widget.Button;
import android.widget.ListView;
import android.widget.Toast;

import com.example.apptruyen_sqlite.adapter.adapterTruyen;
import com.example.apptruyen_sqlite.database.databasedoctruyen;
import com.example.apptruyen_sqlite.model.Truyen;

import java.util.ArrayList;

public class ManAdmin extends AppCompatActivity {
    ListView listView ;
    Button buttonThem;

    ArrayList<Truyen> TruyenArrayList;
    adapterTruyen adapterTruyen;
    databasedoctruyen databasedoctruyen;


    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_man_admin);

        listView=findViewById(R.id.listviewadmin);
        buttonThem=findViewById(R.id.buttonthemtruyen);

        initList();
        buttonThem.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                // lay id tk de nhan biet admin
                Intent intent1 = getIntent();
                int id = intent1.getIntExtra("id",0);
                // gui id qua manthem
                Intent intent = new Intent(ManAdmin.this, ManDangBai.class);
                intent.putExtra("id",id);
                startActivity(intent);
            }
        });
        // longclick se xoa truyen
        listView.setOnItemLongClickListener(new AdapterView.OnItemLongClickListener() {
            @Override
            public boolean onItemLongClick(AdapterView<?> parent, View view, int position, long id) {
                DialogDelete(position);
                return false;
            }
        });
    }
    private void DialogDelete(int position){
        Dialog dialog = new Dialog(this);
        dialog.setContentView(R.layout.dialogdelete);
        //// chỉ tắt khi click button(ngăn nổi bọt)
        dialog.setCanceledOnTouchOutside(false);
        Button btnyes = dialog.findViewById(R.id.yes);
        Button btnno = dialog.findViewById(R.id.no);

        btnyes.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                int idtruyen = TruyenArrayList.get(position).getID();
                //xoa tr
                databasedoctruyen.Delete(idtruyen);

                // cap nhat laij sau khi xoa
                Intent intent = new Intent(ManAdmin.this,ManAdmin.class);
                finish();
                startActivity(intent);
                Toast.makeText(ManAdmin.this,"xoa truyen thanh cong",Toast.LENGTH_SHORT).show();
            }
        });
        btnno.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                dialog.cancel();
            }
        });
        dialog.show();
    }


//// gasn du lieu cho listv khi them
    private void initList() {
        TruyenArrayList = new ArrayList<>();
        databasedoctruyen = new databasedoctruyen(this);


        Cursor cursor1 = databasedoctruyen.getData2();
        while (cursor1.moveToNext()){
            int id = cursor1.getInt(0);
            String tentruyen = cursor1.getString(1);
            String noidung =cursor1.getString(2);
            String anh = cursor1.getString(3);
            int id_tk = cursor1.getInt(4);

            TruyenArrayList.add(new Truyen(id,tentruyen,noidung,anh,id_tk));
            adapterTruyen = new adapterTruyen(getApplicationContext(),TruyenArrayList);

            listView.setAdapter(adapterTruyen);

        }
        cursor1.moveToFirst();
        cursor1.close();
    }
}