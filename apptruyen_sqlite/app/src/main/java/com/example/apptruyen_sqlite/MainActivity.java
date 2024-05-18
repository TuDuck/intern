package com.example.apptruyen_sqlite;

import androidx.annotation.NonNull;
import androidx.appcompat.app.AppCompatActivity;
import androidx.appcompat.widget.Toolbar;
import androidx.core.view.GravityCompat;
import androidx.drawerlayout.widget.DrawerLayout;

import android.content.Intent;
import android.database.Cursor;
import android.os.Bundle;
import android.util.Log;
import android.view.Menu;
import android.view.MenuItem;
import android.view.View;
import android.view.animation.Animation;
import android.view.animation.AnimationUtils;
import android.widget.AdapterView;
import android.widget.ImageView;
import android.widget.ListView;
import android.widget.Toast;
import android.widget.ViewFlipper;


import com.example.apptruyen_sqlite.adapter.adapterchuyenmuc;
import com.example.apptruyen_sqlite.adapter.adapterthongtin;
import com.example.apptruyen_sqlite.database.databasedoctruyen;
import com.example.apptruyen_sqlite.model.TaiKhoan;
import com.example.apptruyen_sqlite.model.Truyen;
import com.example.apptruyen_sqlite.model.chuyenmuc;
import com.google.android.material.navigation.NavigationView;
import com.squareup.picasso.Picasso;
import com.example.apptruyen_sqlite.adapter.adapterTruyen;

import java.util.ArrayList;

public class MainActivity extends AppCompatActivity {
    Menu menu;
    Toolbar toolbar;
    ViewFlipper viewFlipper;
    NavigationView navigationView;
    ListView listView, listViewnew, listViewThongtin;
    DrawerLayout drawerLayout;
    String email;
    String tentaikhoan;
    ArrayList<Truyen> TruyenArraylist;
    adapterTruyen adapterTruyen;
    ArrayList<chuyenmuc> chuyenmucArrayList;
    ArrayList<TaiKhoan> taiKhoanArrayList;
    databasedoctruyen databasedoctruyen;
    adapterchuyenmuc adapterchuyenmuc;
    adapterthongtin adapterthongtin;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        databasedoctruyen = new databasedoctruyen(this);
        Intent intentpq = getIntent();
        int i = intentpq.getIntExtra("phanq",0);
        int idd = intentpq.getIntExtra("idd",0);
        email = intentpq.getStringExtra("email");
        tentaikhoan = intentpq.getStringExtra("tentaikhoan");

        AnhXa();
        ActionViewFlipper();
        ActionBar();

        // bat click
        listViewnew.setOnItemClickListener(new AdapterView.OnItemClickListener() {
            @Override
            public void onItemClick(AdapterView<?> parent, View view, int position, long id) {
                Intent intent = new Intent(MainActivity.this,ManNoiDung.class);

                String tent = TruyenArraylist.get(position).getTenTruyen();
                String noidungt = TruyenArraylist.get(position).getNoiDung();
                intent.putExtra("tentruyen",tent);
                intent.putExtra("noidung",noidungt);
                startActivity(intent);
            }
        });

        listView.setOnItemClickListener(new AdapterView.OnItemClickListener() {
            @Override
            public void onItemClick(AdapterView<?> parent, View view, int position, long id) {
                // dang bai
                if(position == 0){
                    if(i==2){
                        Intent intent = new Intent(MainActivity.this,ManAdmin.class);
                        // gui id tk  qua manadmin
                        intent.putExtra("id",idd);
                        startActivity(intent);
                    }
                    else {
                        Toast.makeText(MainActivity.this,"bạn không có quyền đăng bài",Toast.LENGTH_SHORT).show();
                        Log.e("dang bai","ban không có quyền" );
                    }
                }
                //// phan quyen = 1 thi hien ND
                else if(position==1){
                    Intent intent = new Intent(MainActivity.this, ManThongTin.class);
                    startActivity(intent);
                } else if (position==2) {
                    finish();
                }
            }
        });
    }

    // thanh menu chuyen muc
    private void ActionBar() {
    setSupportActionBar(toolbar);
    getSupportActionBar().setDisplayHomeAsUpEnabled(true);
    toolbar.setNavigationIcon(android.R.drawable.ic_menu_sort_by_size);

    toolbar.setNavigationOnClickListener(new View.OnClickListener() {
        @Override
        public void onClick(View v) {
            drawerLayout.openDrawer(GravityCompat.START);
        }
    });
    }


    // chay quang cao
    private void ActionViewFlipper() {
        ArrayList<String> mangquangcao = new ArrayList<>();
        mangquangcao.add("https://images.toplist.vn/images/800px/rua-va-tho-230179.jpg");
        mangquangcao.add("https://images.toplist.vn/images/800px/deo-chuong-cho-meo-230180.jpg");
        mangquangcao.add("https://images.toplist.vn/images/800px/cu-cai-trang-230181.jpg");
        mangquangcao.add("https://images.toplist.vn/images/800px/de-den-va-de-trang-230182.jpg");
        for(int i = 0; i<mangquangcao.size();i++){
            // dday anh vao mang vaf can chinh
            ImageView img = new ImageView(getApplicationContext());
            Picasso.get().load(mangquangcao.get(i)).into(img);
            img.setScaleType(ImageView.ScaleType.FIT_XY);
            // them anh vao flipper
            viewFlipper.addView(img);
        }
        viewFlipper.setFlipInterval(4000);
        viewFlipper.setAutoStart(true);

        /// goij animation
        Animation animation_slide_in = AnimationUtils.loadAnimation(getApplicationContext(),R.anim.slide_in_right);
        Animation animation_slide_out = AnimationUtils.loadAnimation(getApplicationContext(),R.anim.slide_out_right);

        viewFlipper.setInAnimation(animation_slide_in);
        viewFlipper.setInAnimation(animation_slide_out);
    }


    private void AnhXa() {
    toolbar= findViewById(R.id.toolbar_manhinh);
    viewFlipper = findViewById(R.id.view_fliper);
    navigationView= findViewById(R.id.navigationview);
    listView = findViewById(R.id.listviewmanhinhchinh);
    listViewnew = findViewById(R.id.listviewnew);
    listViewThongtin = findViewById(R.id.listviewthongtin);
    drawerLayout = findViewById(R.id.drawerlayout);

    TruyenArraylist = new ArrayList<>();
        Cursor cursor1 = databasedoctruyen.getData1();
        while (cursor1.moveToNext()){
            int id = cursor1.getInt(0);
            String tentruyen = cursor1.getString(1);
            String noidung = cursor1.getString(2);
            String anh = cursor1.getString(3);
            int id_tk = cursor1.getInt(4);

            TruyenArraylist.add(new Truyen(id,tentruyen,noidung,anh,id_tk));
            adapterTruyen = new adapterTruyen(getApplicationContext(),TruyenArraylist);
            listViewnew.setAdapter(adapterTruyen);

        }
        cursor1.moveToFirst();
        cursor1.close();

        /// thong tin
        taiKhoanArrayList = new ArrayList<>();
        taiKhoanArrayList.add(new TaiKhoan(tentaikhoan,email));

        adapterthongtin = new adapterthongtin(this,R.layout.navigation_thongtin,taiKhoanArrayList);
        listViewThongtin.setAdapter(adapterthongtin);

        // chuyen muc
        chuyenmucArrayList = new ArrayList<>();
        chuyenmucArrayList.add(new chuyenmuc("đăng truyện", R.drawable.ic_post));
        chuyenmucArrayList.add(new chuyenmuc("thông tin", R.drawable.ic_facett));
        chuyenmucArrayList.add(new chuyenmuc("đăng xuất", R.drawable.ic_logout));

        adapterchuyenmuc = new adapterchuyenmuc(MainActivity.this,R.layout.chuyenmuc,chuyenmucArrayList);
        listView.setAdapter(adapterchuyenmuc);

    }


// tao thanh tim kiem
    @Override
    public boolean onCreateOptionsMenu(Menu menu) {
        getMenuInflater().inflate(R.menu.mymenu,menu);

        return true;

    }


    @Override
    public boolean onOptionsItemSelected(@NonNull MenuItem item) {
        int id = item.getItemId();
        while (true){
            if (id == R.id.MenuSearch){
                Intent intent = new Intent(MainActivity.this,ManTimKiem.class);
                startActivity(intent);
                break;
            }else
                break;
        }
        return super.onOptionsItemSelected(item);


    }
}