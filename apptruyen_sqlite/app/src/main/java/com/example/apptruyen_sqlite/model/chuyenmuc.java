package com.example.apptruyen_sqlite.model;

public class chuyenmuc {
    private String tenchuyenmuc;
    private int hinhchuyenmuc;

    public chuyenmuc(){

    }
    public chuyenmuc(String tenchuyenmuc, int hinhchuyenmuc) {
        this.tenchuyenmuc = tenchuyenmuc;
        this.hinhchuyenmuc = hinhchuyenmuc;
    }

    public String getTenchuyenmuc() {
        return tenchuyenmuc;
    }

    public void setTenchuyenmuc(String tenchuyenmuc) {

        this.tenchuyenmuc = tenchuyenmuc;
    }

    public int getHinhchuyenmuc() {

        return hinhchuyenmuc;
    }

    public void setHinhchuyenmuc(int hinhchuyenmuc) {
        this.hinhchuyenmuc = hinhchuyenmuc;
    }
}
