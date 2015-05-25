/**
 * Created by User on 13.5.2015 ã..
 */
//100 points
var test1 = [
    'sentinel .exe 15MB',
    'zoomIt .msi 3MB',
    'skype .exe 45MB',
    'trojanStopper .bat 23MB',
    'kindleInstaller .exe 120MB',
    'setup .msi 33.4MB',
    'winBlock .bat 1MB'
];
var test2 = [
    'eclipse .tar.gz 198.00MB',
    'uTorrent .gyp 33.02MB',
    'nodeJS .gyp 14MB',
    'nakov-naked .jpeg 3MB',
    'gnuGPL .pdf 5.6MB',
    'skype .tar.gz 66MB',
    'selfie .jpeg 7.24MB',
    'myFiles .tar.gz 783MB'
];

function solve(params){
    var files, line, lines, splitLine, keys, result, i;
    files = {};
    for (i = 0; i < params.length; i++) {
        splitLine = params[i].split(' ');
        splitLine.forEach(function(str){
            str.trim();
        })

        if(!files.hasOwnProperty(splitLine[1])){
            files[splitLine[1]] = {};
            files[splitLine[1]].files = [];
            files[splitLine[1]].memory = 0;
        }

        files[splitLine[1]].files.push(splitLine[0]);
        files[splitLine[1]].memory += ( parseFloat(splitLine[2]));
    }
    for (var obj in files) {
        files[obj].files.sort();
        files[obj].memory = files[obj].memory.toFixed(2);
    }
    keys = Object.keys(files);
    keys.sort();
    lines = [];
    for (i = 0; i < keys.length; i++) {
        lines.push( '"' +  keys[i] + '"' + ':' + JSON.stringify(files[keys[i]]));
    }

    result = '{' + lines.join(',') + '}';
    return result;
}
console.log(solve(test1));
console.log(solve(test2));