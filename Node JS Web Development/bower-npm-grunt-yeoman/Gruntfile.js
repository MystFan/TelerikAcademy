module.exports = function (grunt) {
    grunt.initConfig({
        connect: {
            options: {
                port: 9578,
                livereload: 35729,
                hostname: 'localhost'
            },
            livereload: {
                options: {
                    open: true,
                    base: [
                        'DEV'
                    ]
                }
            }
        },
        watch: {
            jade: {
                files: ['APP/jade/**/*.jade'],
                tasks: ['jade'],
                options: {
                    livereload: true
                }
            },
            styles: {
                files: ['APP/stylus/**/*.styl'],
                tasks: ['stylus'],
                options: {
                    livereload: true
                }
            },
            coffee: {
                files: ['APP/coffee-script/**/*.coffee'],
                tasks: ['coffee', 'jshint'],
                options: {
                    livereload: true
                }
            },
            livereload: {
                options: {
                    livereload: '35729'
                },
                files: [
                    'app/**/*.html',
                    'app/**/*.css',
                ]
            }
        },
        coffee: {
            compile: {
                options: {
                    compress: false
                },
                files: {
                    'DEV/scripts/coffee.js': 'APP/coffee-script/coffee.coffee'
                }
            }
        },
        jshint: {
            all: [
                'DEV/scripts/**/*.js'
            ]
        },
        jade: {
            compile: {
                options: {
                    pretty: true
                },
                files: {
                    'DEV/index.html': 'APP/jade/index.jade'
                }
            }
        },
        stylus: {
            compile: {
                options: {
                    compress: false
                },
                files: {
                    'DEV/styles/form.css': 'APP/stylus/form.styl',
                    'DEV/styles/images.css': 'APP/stylus/images.styl'
                }
            }
        },
        csslint: {
            lax: {
                src: ['DEV/styles/**/*.mim.css', 'DEV/styles/**/*.css']
            }
        },
        copy: {
            main: {
                files: [
                    {
                        expand: true,
                        flatten: true,
                        src: ['APP/images/*'],
                        dest: 'DEV/images/',
                        filter: 'isFile'
                    },
                    {
                        expand: true,
                        flatten: true,
                        src: ['DEV/images/*'],
                        dest: 'DIST/images/',
                        filter: 'isFile'
                    }
                ]
            }
        },
        concat: {
            dist: {
                src: ['DEV/styles/form.css', 'DEV/styles/images.css'],
                dest: 'DIST/styles/site.min.css',
            },
        },
        cssmin: {
            target: {
                files: {
                    'DIST/styles/site.min.css': ['DEV/styles/site.min.css']
                }
            }
        },
        uglify: {
            options: {
                mangle: false
            },
            my_target: {
                files: {
                    'DIST/scripts/coffee.min.js': ['DEV/scripts/coffee.js']
                }
            }
        },
        htmlmin: {
            dist: {
                options: {
                    collapseWhitespace: true
                },
                files: {
                    'DIST/index.html': 'DEV/index.html'
                }
            }
        }
    });

    grunt.loadNpmTasks('grunt-contrib-stylus');
    grunt.loadNpmTasks('grunt-contrib-coffee');
    grunt.loadNpmTasks('grunt-contrib-jshint');
    grunt.loadNpmTasks('grunt-contrib-jade');
    grunt.loadNpmTasks('grunt-contrib-csslint');
    grunt.loadNpmTasks('grunt-contrib-copy');
    grunt.loadNpmTasks('grunt-contrib-concat');
    grunt.loadNpmTasks('grunt-contrib-cssmin');
    grunt.loadNpmTasks('grunt-contrib-htmlmin');
    grunt.loadNpmTasks('grunt-contrib-uglify');
    grunt.loadNpmTasks('grunt-contrib-connect');
    grunt.loadNpmTasks('grunt-contrib-watch');

    grunt.registerTask('serve', ['coffee', 'jshint', 'jade', 'stylus', 'copy', 'connect', 'watch']);
    grunt.registerTask('build', ['coffee', 'stylus', 'jade', 'jshint', 'csslint', 'concat', 'cssmin', 'uglify', 'htmlmin']);
}