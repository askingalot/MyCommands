use std::env::{args};
use std::path::Path;
use std::fs::{read_to_string};

fn main() {
    let filenames = args().skip(1);
    for name in filenames {
        if !Path::new(&name).exists() {
            println!("File not found: {}", name);
            continue;
        }
        if let Ok(text) = read_to_string(&name) {
            println!("{}", text);
        } else {
            println!("Cannot read file: {}", name);
        }
    }
}
