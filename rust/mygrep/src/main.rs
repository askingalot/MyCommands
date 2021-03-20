use std::env::args;
use std::fs::File;
use std::io::{prelude::*, stdout, BufReader};
use std::path::Path;

fn main() {
    let args: Vec<String> = args().skip(1).take(2).collect();
    if args.len() != 2 {
        println!("You must supply a filename and search text");
        return;
    }

    let filename = &args[0];
    if !Path::new(&filename).exists() {
        println!("File not found: {}", filename);
        return;
    }

    let file = File::open(filename).expect(format!("Unable to read file: {}", filename).as_str());
    let reader = BufReader::new(file);

    let search_text = &args[1];
    let line_data = reader.lines().map(|l| l.unwrap()).enumerate();
    let std_out = stdout();
    for (i, line) in line_data {
        if line.contains(search_text) {
            write!(&std_out, "{}: {}\n", i + 1, line);
        }
    }
}
